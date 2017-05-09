using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebSocketSharp;
using System.Threading;
using System.IO;

namespace SCChatBot
{ 
    public partial class Form1 : Form
    {
        WebSocket ws = new WebSocket("wss://connect-bot.classic.blizzard.com/v1/rpc/chat", "json");

        public int lastRequestId = 0;

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

        public class ChatConnectEvent
        {
            public string command { get; set; }
            public int request_id { get; set; }
            public Dictionary<string, string> payload { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        //| Area  |  Code  |  Reason
        //| 8     |   1    | Not connected to chat
        //| 8     |   2    | Bad request
        //| 6     |   5    | Request timed out
        //| 6     |   8    | Hit rate limit


        // websocket-sharp: https://github.com/sta/websocket-sharp/blob/master/README.md
        // JSON.NET documentation: http://www.newtonsoft.com/json/help/html/Introduction.htm

        // When connection is established, the client will need to send an authentication request with the API key:
        public void Authentication()
        {
           

            var apiKeyFile = @"C:\Users\mdinger\Desktop\ChatBotAPIKey.txt";
            var apiKey = File.ReadAllText(apiKeyFile);

            var auth = new Auth
            {
                command = "Botapiauth.AuthenticateRequest",
                request_id = ++lastRequestId,
                payload = new Dictionary<string, string>
                {
                    { "api_key", apiKey }
                }
            };
            var authJson = JsonConvert.SerializeObject(auth, Formatting.Indented);

            ws.OnOpen += (sender, e) =>
            {
                ws.Send(authJson);
               
            };

            ws.OnError += (sender, e) =>
            {
                MessageBox.Show(e.Message, "Error:");
            };

            ws.OnMessage += (sender, e) =>
            {
                MessageBox.Show(e.Data);
            };

            ws.OnClose += (sender, e) =>
            {
               if (e.Code == 1005)
                {
                    MessageBox.Show("Disconnected from the server. Please verify your API key is valid.", "Error:");
                }
            };

            ws.Connect();
        }

        // Connect the bot to the gateway and chat channel
        public void ChatConnect()
        {


            var chatConnect = new ChatConnection
            {
                command = "Botapichat.ConnectRequest",
                request_id = ++lastRequestId,
                payload = new Dictionary<string, string>
                {
                    
                }
            };
            var chatConnectionJson = JsonConvert.SerializeObject(chatConnect, Formatting.Indented);

            var chatConnectEvent = new ChatConnectEvent
            {
                command = "Botapichat.ConnectEventRequest",
                request_id = ++lastRequestId,
                payload = new Dictionary<string, string>
                {
                    {"channel", "Op Z3roFlaw" }
                }
            };
            var chatConnectEventJson = JsonConvert.SerializeObject(chatConnectEvent, Formatting.Indented);

            ws.Send(chatConnectionJson);



        }

        // Disconnects the bot from the gateway and chat channel
        public void ChatDisconnect()
        {

        }

        // Sends a chat message to the channel
        public void ChatSendMessage()
        {

        }

        // Sends a chat message to one user in the channel
        public void ChatSendWhisper()
        {

        }

        // A message was posted to the channel
        // Type is one of: Whisper, Channel, ServerInfo, ServerError, Emote
        public void OnMessageEvent()
        {

        }

        // A user has joined the current channel or got an update
        // Flags are: Admin, Moderator, Speaker, MuteGlobal, MuteWhisper 
        // Attributes are: ProgramId, Rate, Rank, Wins
        public void OnUserUpdateEvent()
        {

        }

        // A user in the current channel has left
        public void OnUserLeaveEvent()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChatConnect();
        }
    }
}
