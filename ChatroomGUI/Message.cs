using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Message
    {
        public Client sender;
        public string Body;
        public string UserId;
        public DateTime messageTime;
        public bool privateMessage;
        public string privateMessageReceiver;
        public Message(Client Sender, string Body)
        {
            sender = Sender;
            this.Body = Body;
            UserId = sender?.UserId;
            messageTime = DateTime.Now;
            if (ClientPrivateMessage())
            {
                privateMessageReceiver = GetPrivateMessageReceiver();
                this.Body = GetMessage();
                privateMessage = true;
            }
                
        }
        public string Display()
        {
            string message = $"{UserId}-{messageTime.ToString("hh:mm:ss tt")} >>> {Body}";
            return message;
        }
        public string DisplayPrivateMessage()
        {
            string message = $"##PM##{UserId}-{messageTime.ToString("hh:mm:ss tt")} >>> {Body}";
            return message;
        }
        private string GetMessage()
        {
            return Body.Substring(Body.IndexOf("MESSAGE:") + 8);
        }
        private string GetPrivateMessageReceiver()
        {
            int receiverNameStart = 10;
            string receiverName = Body.Substring(receiverNameStart);
            receiverName = receiverName.Remove(receiverName.IndexOf("MESSAGE:"));
            return receiverName;
        }
        private bool ClientPrivateMessage()
        {
            return Body.Contains("##PM##");
        }
    }
}
