using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Client
{
    public partial class ChatConsole : Form
    {
        private string chatName;
        TcpClient clientSocket;
        NetworkStream stream;
        private string chatMessage;

        public ChatConsole()
        {
            InitializeComponent();

        }
        public void Receive()
        {
            char[] charsToTrim = { '\0' };
            while (true)
            {
                try
                {
                    byte[] receivedMessage = new byte[256];
                    stream.Read(receivedMessage, 0, receivedMessage.Length);
                    string message = Encoding.ASCII.GetString(receivedMessage);
                    ChatMessages.Invoke((Action)(() =>
                    {
                        if (MyMessage(message.Trim(charsToTrim)))
                        {
                            ChatMessages.SelectionColor = Color.Red;
                            ChatMessages.AppendText($"\n{message}\r");
                        }
                        else
                        {
                            ChatMessages.SelectionColor = Color.Black;
                            ChatMessages.AppendText($"\n{message}\r");
                        }
                    }));

                }
                catch (Exception e)
                {
                    ChatMessages.Text = "Error Receiving Servers Message " + e;
                }
            }
        }
        private bool MyMessage(string text)
        {
            bool myMessage = true;
            for (int i = 0; i < chatName.Length; i++)
                if (chatName[i] != text[i])
                    myMessage = false;
            return myMessage;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
            StartReceiveThread();
            chatName = ChatName.Text;
            SendChatName();
            this.AcceptButton = Submit;
            ChatName.ReadOnly = true;
            ChatMessages.ReadOnly = true;
            Connect.Enabled = false;
        }
        public void ConnectToServer()
        {
            clientSocket = new TcpClient();
            clientSocket.Connect("127.0.0.1", 9999);
            stream = clientSocket.GetStream();
        }
        public void StartReceiveThread()
        {
            Thread receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.Start();
        }
        public void SendChatName()
        {
            string messageString = chatName;
            byte[] message = Encoding.ASCII.GetBytes(messageString);
            stream.Write(message, 0, message.Count());
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            chatMessage = ClientMessages.Text;
            ClientMessages.Text = "";
            Send();

        }
        public void Send()
        {
            try
            {
                string messageString = chatMessage;
                byte[] message = Encoding.ASCII.GetBytes(messageString);
                stream.Write(message, 0, message.Count());
            }
            catch (Exception e)
            {
                ChatMessages.Text = "Error trying to send to server " + e;
            }
        }
    }
}
