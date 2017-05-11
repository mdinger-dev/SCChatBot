using System.Collections.Generic;

namespace SCChatBot
{
    public class MessageClasses
    {
        public class Auth
        {
            public string command { get; set; }
            public int request_id { get; set; }
            public Dictionary<string, string> payload { get; set; }
        }

        public class ChatConnection
        {
            public string command { get; set; }
            public int request_id { get; set; }
            public Dictionary<string, string> payload { get; set; }
        }

        public class ChatDisconnection
        {
            public string command { get; set; }
            public int request_id { get; set; }
            public Dictionary<string, string> payload { get; set; }
        }

        public class SendChatMessage
        {
            public string command { get; set; }
            public int request_id { get; set; }
            public Dictionary<string, string> payload { get; set; }
        }

        public class SendChatWhisper
        {
            public string command { get; set; }
            public int request_id { get; set; }
            public Dictionary<string, string> payload { get; set; }
        }
    }
}