using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        TcpClient clientSocket;
        NetworkStream stream;
        string chatName;
        ChatConsole myConsole = new ChatConsole();

        public Client(string IP, int port)
        {
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            stream = clientSocket.GetStream();
            ReceiveChatName();
            SetChatName();
            SendChatName();
        }
        public void ReceiveChatName()
        {
            byte[] receivedMessage = new byte[256];
            stream.Read(receivedMessage, 0, receivedMessage.Length);
            string message = Encoding.ASCII.GetString(receivedMessage);
        // display message in text box!!!    UI.DisplayMessage(message);
        }
        public string SetChatName()
        {
       // GET CHAT NAME FROM BOX     string response = UI.GetInput();
            if (response != "")
                chatName = response;
            else
                SetChatName();
            return chatName;
        }
        public void SendChatName()
        {
            string messageString = chatName;
            byte[] message = Encoding.ASCII.GetBytes(messageString);
            stream.Write(message, 0, message.Count());
        }
    }
}
