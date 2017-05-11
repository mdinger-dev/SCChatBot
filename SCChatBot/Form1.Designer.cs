using System.Windows.Forms;

namespace SCChatBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        
        
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAuthConnect = new System.Windows.Forms.Button();
            this.lblAuthConnection = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblAuthConnectionStatus = new System.Windows.Forms.Label();
            this.btnChatDisconnect = new System.Windows.Forms.Button();
            this.txtBoxChatMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChatConnect = new System.Windows.Forms.Button();
            this.listBoxUsersInChannel = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthConnect
            // 
            this.btnAuthConnect.Location = new System.Drawing.Point(195, 12);
            this.btnAuthConnect.Name = "btnAuthConnect";
            this.btnAuthConnect.Size = new System.Drawing.Size(137, 27);
            this.btnAuthConnect.TabIndex = 0;
            this.btnAuthConnect.Text = "WebSocket Authenticate";
            this.btnAuthConnect.UseVisualStyleBackColor = true;
            this.btnAuthConnect.Click += new System.EventHandler(this.btnAuthConnect_Click);
            // 
            // lblAuthConnection
            // 
            this.lblAuthConnection.AutoSize = true;
            this.lblAuthConnection.Location = new System.Drawing.Point(249, 187);
            this.lblAuthConnection.Name = "lblAuthConnection";
            this.lblAuthConnection.Size = new System.Drawing.Size(0, 13);
            this.lblAuthConnection.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(371, 187);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(101, 27);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblAuthConnectionStatus
            // 
            this.lblAuthConnectionStatus.AutoSize = true;
            this.lblAuthConnectionStatus.Location = new System.Drawing.Point(338, 19);
            this.lblAuthConnectionStatus.Name = "lblAuthConnectionStatus";
            this.lblAuthConnectionStatus.Size = new System.Drawing.Size(92, 13);
            this.lblAuthConnectionStatus.TabIndex = 5;
            this.lblAuthConnectionStatus.Text = "Connection State:";
            // 
            // btnChatDisconnect
            // 
            this.btnChatDisconnect.Location = new System.Drawing.Point(12, 55);
            this.btnChatDisconnect.Name = "btnChatDisconnect";
            this.btnChatDisconnect.Size = new System.Drawing.Size(99, 27);
            this.btnChatDisconnect.TabIndex = 2;
            this.btnChatDisconnect.Text = "Chat Disconnect";
            this.btnChatDisconnect.UseVisualStyleBackColor = true;
            this.btnChatDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtBoxChatMessage
            // 
            this.txtBoxChatMessage.Location = new System.Drawing.Point(12, 191);
            this.txtBoxChatMessage.MaxLength = 223;
            this.txtBoxChatMessage.Name = "txtBoxChatMessage";
            this.txtBoxChatMessage.Size = new System.Drawing.Size(353, 20);
            this.txtBoxChatMessage.TabIndex = 3;
            this.txtBoxChatMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxChatMessage_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCChatBot.Properties.Resources.GrayDot;
            this.pictureBox1.Location = new System.Drawing.Point(436, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnChatConnect
            // 
            this.btnChatConnect.Location = new System.Drawing.Point(12, 22);
            this.btnChatConnect.Name = "btnChatConnect";
            this.btnChatConnect.Size = new System.Drawing.Size(99, 27);
            this.btnChatConnect.TabIndex = 1;
            this.btnChatConnect.Text = "Chat Connect";
            this.btnChatConnect.UseVisualStyleBackColor = true;
            this.btnChatConnect.Click += new System.EventHandler(this.btnChatConnect_Click);
            // 
            // listBoxUsersInChannel
            // 
            this.listBoxUsersInChannel.FormattingEnabled = true;
            this.listBoxUsersInChannel.Location = new System.Drawing.Point(129, 71);
            this.listBoxUsersInChannel.Name = "listBoxUsersInChannel";
            this.listBoxUsersInChannel.Size = new System.Drawing.Size(120, 95);
            this.listBoxUsersInChannel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 230);
            this.Controls.Add(this.listBoxUsersInChannel);
            this.Controls.Add(this.btnChatConnect);
            this.Controls.Add(this.txtBoxChatMessage);
            this.Controls.Add(this.btnChatDisconnect);
            this.Controls.Add(this.lblAuthConnectionStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.lblAuthConnection);
            this.Controls.Add(this.btnAuthConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SC Chat Bot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthConnect;
        private System.Windows.Forms.Label lblAuthConnection;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAuthConnectionStatus;
        private System.Windows.Forms.Button btnChatDisconnect;
        private System.Windows.Forms.TextBox txtBoxChatMessage;
        private System.Windows.Forms.Button btnChatConnect;
        private ListBox listBoxUsersInChannel;
    }
}

