using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace MySockets
{
    public class Server
    {
        public class User
        {

            private Socket _clientSocket = null;
            private Queue<string> _messages = null;
            private Thread _th = null;
            private int _userId;
            public User(Socket socket, Queue<string> messages, int userId)
            {
                _userId = userId;
                _th = new Thread(ReceiveMessage);
                _clientSocket = socket;
                _messages = messages;
                _th.Start();
            }

            public void ReceiveMessage()
            {
                try
                {
                    while (true)
                    {  // Data buffer
                        byte[] bytes = new Byte[1024];
                        string data = null;

                        while (true)
                        {

                            int numByte = _clientSocket.Receive(bytes);

                            data += Encoding.ASCII.GetString(bytes,
                                                       0, numByte);

                            if (data.IndexOf("<EOF>") > -1)
                                break;
                        }
                        string auxMsg = data.Replace("<EOF>", "");
                        if (auxMsg == "bye")
                        { 
                            CloseConnection();
                            return;
                        }
                        Console.WriteLine("Received: "+ auxMsg);
                        _messages.Enqueue(auxMsg);
                    }
                }

                catch (Exception e)
                {
                    _messages.Enqueue(e.ToString());
                }

            }

           public bool SendMessage(string msg)
            {

                try
                {
                    byte[] message = Encoding.ASCII.GetBytes(msg);

                    // Send a message to Client
                    // using Send() method
                    _clientSocket.Send(message);
                    return true;
                }

                catch (Exception e)
                {
                    _messages.Enqueue(e.ToString());
                    return false;
                }
            }

            public void CloseConnection()
            {
                try
                {
                    _messages.Enqueue(_userId.ToString()+":disconnect");
                    _clientSocket.Shutdown(SocketShutdown.Both);
                    _clientSocket.Close();
                    _th.Abort();
                }
                catch (Exception e)
                {
                    _messages.Enqueue(e.ToString());
                }
            }
        }
        private List<User> _users = new List<User>();
        private Queue<string> _messages = new Queue<string>();
        private List<bool> _id = new List<bool>() {false, false, false, false, false};
        public Server()
        {
            Thread th = new Thread(UpdateAllUsers);
            th.Start();
            StartServer();
        }
        private int GetFreeId()
        {
            for (int i = 0; i < _id.Count; i++)
                if (_id[i] == false)
                {
                    return i;
                }
            return -1;
        }

        private string AllUsersToString()
        {
            string result = "";
            for (int i = 0; i < _id.Count; i++)
                if(_id[i] == true)
                    result+=","+i.ToString();

            return result;
        }

        void UpdateAllUsers()
        {
            while (true)
            {
                while (_messages.Count != 0)
                {
                    string message = _messages.Dequeue();
                    Console.WriteLine(message+"\r\nUsers: "+_users.Count);




                    for(int i=0; i<_users.Count; i++)
                    {

                        if (!_users[i].SendMessage(message))
                        { 
                            _users[i].CloseConnection();
                            _users.RemoveAt(i);
                            --i;
                            _id[i] = false;
                        }
                    }
                }
            }
        }


        public void StartServer()
        {
            // Establish the local endpoint
            // for the socket. Dns.GetHostName
            // returns the name of the host
            // running the application.
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

            // Creation TCP/IP Socket using
            // Socket Class Constructor
            Socket listener = new Socket(ipAddr.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            try
            {

                // Using Bind() method we associate a
                // network address to the Server Socket
                // All client that will connect to this
                // Server Socket must know this network
                // Address
                listener.Bind(localEndPoint);

                // Using Listen() method we create
                // the Client list that will want
                // to connect to Server
                listener.Listen(10);

                while (true)
                {

                    // Console.WriteLine("Waiting connection ... ");

                    // Suspend while waiting for
                    // incoming connection Using
                    // Accept() method the server
                    // will accept connection of client
                    int pos = GetFreeId();
                    if (pos != -1)
                    {
                        
                        _users.Add(new User(listener.Accept(), _messages, pos));
                        string result = AllUsersToString();
                        _users[_users.Count - 1].SendMessage(pos.ToString() + result);
                        Thread.Sleep(500);
                        _messages.Enqueue(pos+":connect");
                        _id[pos] = true;

                    }

                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
