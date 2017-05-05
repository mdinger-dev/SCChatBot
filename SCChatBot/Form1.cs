using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebSocketSharp;

namespace SCChatBot
{ 
    public partial class Form1 : Form
    {
        WebSocket ws = new WebSocket("wss://connect-bot.classic.blizzard.com/v1/rpc/chat");

        public int lastRequestId = 0;

        public class Auth
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
            ws.Connect();

            var auth = new Auth
            {
                command = "Botapiauth.AuthenticateRequest",
                request_id = ++lastRequestId,
                payload = new Dictionary<string, string>
                {
                    { "api_key", "c2a55235c0b934c18df9fe2ffe77b0af815228baa5124a009b39bac1" }
                }
            };
            var authJson = JsonConvert.SerializeObject(auth, Formatting.Indented);
            ws.Send(authJson);
        }

        // Connect the bot to the gateway and chat channel
        public void ChatConnect()
        {

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
            var isAlive = ws.IsAlive;
            MessageBox.Show(isAlive.ToString());
        }
    }
}
