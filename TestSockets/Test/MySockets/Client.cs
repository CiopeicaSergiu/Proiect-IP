using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace Test
{
    public class Client
    {
        // ExecuteClient() Method
        private Socket _sender = null;
        private IPEndPoint _localEndPoint = null;
        private Queue<string> _messagesIn = null;
        private Queue<string> _messagesOut = null;
        private bool _clientQuit = false;
        private Thread _t1 = null;
        private Thread _t2 = null;  
        public Client(Queue<string> messagesIn, Queue<string> messagesOut)
        {
            _messagesIn = messagesIn;
            _messagesOut = messagesOut;
            try
            {
                // Establish the remote endpoint
                // for the socket. This example
                // uses port 11111 on the local
                // computer.
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                _localEndPoint = new IPEndPoint(ipAddr, 11111);

                // Creation TCP/IP Socket using
                // Socket Class Constructor
                _sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Connect Socket to the remote
                // endpoint using method Connect()
                _sender.Connect(_localEndPoint);
                 _t1 = new Thread(ReceiveMessage);
                _t1.Start();
                _t2 = new Thread(SendMessage);
                _t2.Start();

            }
            catch (ArgumentNullException ane)
            {

                _messagesIn.Enqueue("ArgumentNullException : "+ ane.ToString());
            }

            catch (SocketException se)
            {

                _messagesIn.Enqueue("SocketException : "+ se.ToString());
            }

            catch (Exception e)
            {
                _messagesIn.Enqueue("Unexpected exception : "+e.ToString());
            }
        }

        public void ReceiveMessage()
        {
            
            try
            {
                while (true)
                {// Data buffer
                    byte[] messageReceived = new byte[1024];
                    int byteRecv = _sender.Receive(messageReceived);
                    _messagesIn.Enqueue(Encoding.ASCII.GetString(messageReceived, 0, byteRecv));
                }
            }
            catch (ArgumentNullException ane)
            {

                _messagesIn.Enqueue("ArgumentNullException : "+ ane.ToString());
            }

            catch (SocketException se)
            {

                _messagesIn.Enqueue("SocketException : "+se.ToString());
            }

            catch (Exception e)
            {
                _messagesIn.Enqueue("Unexpected exception : "+ e.ToString());
            }
        }
        public void SendMessage()
        {


            try
            {


                while (true)
                {// Creation of message that
                 // we will send to Server
                    while (_messagesOut.Count != 0)
                    {
                        byte[] messageSent = Encoding.ASCII.GetBytes(_messagesOut.Dequeue() + "<EOF>");
                        int byteSent = _sender.Send(messageSent);
                    }
                }
            }
            catch (ArgumentNullException ane)
            {

                _messagesIn.Enqueue("ArgumentNullException : "+ane.ToString());
            }

            catch (SocketException se)
            {

                _messagesIn.Enqueue("SocketException : "+se.ToString());
            }

            catch (Exception e)
            {
                _messagesIn.Enqueue("Unexpected exception : "+ e.ToString());
            }



        }

        public void CloseConnection()
        {

            // Close Socket using
            // the method Close()
            try
            {
                _t1.Abort();
                _t2.Abort();
                _sender.Shutdown(SocketShutdown.Both);
                _sender.Close();
            }
            catch (ArgumentNullException ane)
            {

                _messagesIn.Enqueue("ArgumentNullException : "+ane.ToString());
            }

            catch (SocketException se)
            {

                _messagesIn.Enqueue("SocketException : "+ se.ToString());
            }

            catch (Exception e)
            {
                _messagesIn.Enqueue("Unexpected exception : "+ e.ToString());
            }
        }

    }
}
