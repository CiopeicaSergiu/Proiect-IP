using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Test
{
    public partial class Aplicatie : Form
    {
        private Queue<string> _messagesOut = new Queue<string>();
        private Queue<string> _messagesIn = new Queue<string>();
        private Client _client;
        public Aplicatie()
        {
            InitializeComponent();
            this.FormClosing += delegate {
               _client.CloseConnection();
            };
            _client = new Client(_messagesIn, _messagesOut);

        }

        private void Send(object sender, EventArgs e)
        {
            string msg = "\r\n"+_usernameTextBox.Text + ": " + _userTextBox.Text;
           _messagesOut.Enqueue(msg);
           // _messagesOut.Enqueue(_usernameTextBox.Text + ": " + _userTextBox.Text);
            //ExecuteClient(_userTextBox.Text);
        }

        private void ReadMessageEveryTick(object sender, EventArgs e)
        {
            if (_messagesIn.Count != 0)
                _chatTextBox.Text += _messagesIn.Dequeue();
        }

        private void Quit(object sender, EventArgs e)
        {
            
            this.Close();
        }


    }
}
