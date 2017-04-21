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
        Thread receiveThread;
        bool clientActive;

        public ChatConsole()
        {
            InitializeComponent();
            clientActive = true;

        }
        public void Receive()
        {
            while (clientActive)
            {
                try
                {
                    byte[] receivedMessage = new byte[256];
                    stream.Read(receivedMessage, 0, receivedMessage.Length);
                    string message = Encoding.ASCII.GetString(receivedMessage);
                    ChatMessages.Invoke((Action)(() => { PrintMessageToScreen(message); }));
                }
                catch (Exception e)
                {
                    ChatMessages.Text = "Error Receiving Servers Message " + e;
                }
            }
            clientSocket.Close();
        }
        private void PrintMessageToScreen(string message)
        {
            char[] charsToTrim = { '\0' };
            message.Trim(charsToTrim);
            if (clientActive && message.Contains("##PM##"))
            {
                ChatMessages.SelectionColor = Color.Blue;
                ChatMessages.AppendText($"\n{message.Substring(6)}\r");
            }
            else if (clientActive && MyMessage(message))
            {
                ChatMessages.SelectionColor = Color.Red;
                ChatMessages.AppendText($"\n{message}\r");
            }
            else if (clientActive)
            {
                ChatMessages.SelectionColor = Color.Black;
                ChatMessages.AppendText($"\n{message}\r");
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
            PrepareChatWindow();
        }
        private void PrepareChatWindow()
        {
            this.AcceptButton = Submit;
            ChatName.ReadOnly = true;
            ChatMessages.ReadOnly = true;
            Connect.Enabled = false;
            Leave.Enabled = true;
        }
        public void ConnectToServer()
        {
            clientSocket = new TcpClient();
            clientSocket.Connect("127.0.0.1", 9999);
            stream = clientSocket.GetStream();
        }
        public void StartReceiveThread()
        {
            receiveThread = new Thread(new ThreadStart(Receive));
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
            if (PrivateMessageToggle.Checked)
            {
                BuildPrivateMessage();
                ClientMessages.Text = "";
            }
            else
            {
                chatMessage = ClientMessages.Text;
                ClientMessages.Text = "";
            }
            Send();


        }
        private void BuildPrivateMessage()
        {
            chatMessage = $"##PM## TO:{PrivateMessageChatName.Text}MESSAGE:{ClientMessages.Text}";
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

        private void Leave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to Leave?", "Dialog Title", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SendLeaveMessageToServer();
                clientActive = false;
                Application.Exit();
            }
        }
        private void SendLeaveMessageToServer()
        {
            chatMessage = "##LEAVE##";
            Send();
        }
        private void ChatConsole_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SendLeaveMessageToServer();
                clientActive = false;
                Application.Exit();
            }
        }

        private void PrivateMessageToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivateMessageToggle.Checked)
                PrivateMessageChatName.Enabled = true;
            else
                PrivateMessageChatName.Enabled = false;
        }
    }
}
