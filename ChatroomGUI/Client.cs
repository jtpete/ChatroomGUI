using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client
    {
        NetworkStream stream;
        TcpClient client;
        public string UserId;
        public Nullable<DateTime> startChat;
        public Nullable<DateTime> endChat;
        bool clientDone;

        public Client(NetworkStream Stream, TcpClient Client)
        {
            stream = Stream;
            client = Client;
            ReceiveNewUserId();
            startChat = DateTime.Now;
            clientDone = false;
        }
        public async Task Send(string Message)
        {
            try
            {
                byte[] message = Encoding.ASCII.GetBytes(Message);
                await stream.WriteAsync(message, 0, message.Count());
            }
            catch (Exception e)
            {
                RemoveClient();
                Message message = new Message(this, NotifyStatus());
                Server.messageQueue.Enqueue(message);
                client.Close();
            }
        }
        public void Recieve()
        {
            while (!clientDone)
            {
                char[] charsToTrim = { '\0' };
                try
                {
                    byte[] recievedMessage = new byte[256];
                    stream.Read(recievedMessage, 0, recievedMessage.Length);
                    string recievedMessageString = Encoding.ASCII.GetString(recievedMessage);
                    ProcessMessage(recievedMessageString.Trim(charsToTrim));
                }
                catch (Exception e)
                {
                    RemoveClient();
                    Message message = new Message(this, NotifyStatus().Trim(charsToTrim));
                    Server.messageQueue.Enqueue(message);
                    client.Close();
                    clientDone = true;
                }
            }
        }
        private void ProcessMessage(string message)
        {
            if (ClientLeft(message))
            {
                RemoveClient();
                Message aMessage = new Message(this, NotifyStatus());
                Server.messageQueue.Enqueue(aMessage);
                client.Close();
                clientDone = true;
            }
            else
            {
                Message aMessage = new Message(this, message);
                Server.messageQueue.Enqueue(aMessage);
            }
        }
        private bool ClientLeft(string message)
        {
            return message.Contains("##LEAVE##");
        }
        public void ReceiveNewUserId()
        {
            char[] charsToTrim = { '\0' };
            byte[] recievedMessage = new byte[256];
            try
            {
                stream.Read(recievedMessage, 0, recievedMessage.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("New User Send/Receive Server Error" + e);
            }
            string recievedMessageString = Encoding.ASCII.GetString(recievedMessage);
            UserId = recievedMessageString.Trim(charsToTrim);

        }
        public void ReceiveDifferentUserId()
        {
            try
            {
                Send("That Chat Id already exists...please choose a different name.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Different Id Send Server Error" + e);
            }
            ReceiveNewUserId();
        }
        public void RemoveClient()
        {
            endChat = DateTime.Now;
        }
        public string NotifyStatus()
        {
            if (!endChat.HasValue)
                return "Has entered the chatroom.";
            else
                return "Has left the chatroom.";
        }
    }
}
