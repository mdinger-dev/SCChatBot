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
            this.btnAuthConnect = new System.Windows.Forms.Button();
            this.lblAuthConnection = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblAuthConnectionStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtBoxChatMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthConnect
            // 
            this.btnAuthConnect.Location = new System.Drawing.Point(371, 45);
            this.btnAuthConnect.Name = "btnAuthConnect";
            this.btnAuthConnect.Size = new System.Drawing.Size(99, 27);
            this.btnAuthConnect.TabIndex = 0;
            this.btnAuthConnect.Text = "Connect";
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
            this.btnSendMessage.TabIndex = 3;
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
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(371, 78);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(99, 27);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtBoxChatMessage
            // 
            this.txtBoxChatMessage.Location = new System.Drawing.Point(131, 191);
            this.txtBoxChatMessage.Name = "txtBoxChatMessage";
            this.txtBoxChatMessage.Size = new System.Drawing.Size(234, 20);
            this.txtBoxChatMessage.TabIndex = 7;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 230);
            this.Controls.Add(this.txtBoxChatMessage);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblAuthConnectionStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.lblAuthConnection);
            this.Controls.Add(this.btnAuthConnect);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtBoxChatMessage;
    }
}

