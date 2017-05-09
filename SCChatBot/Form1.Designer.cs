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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuthConnect
            // 
            this.btnAuthConnect.Location = new System.Drawing.Point(309, 12);
            this.btnAuthConnect.Name = "btnAuthConnect";
            this.btnAuthConnect.Size = new System.Drawing.Size(75, 23);
            this.btnAuthConnect.TabIndex = 0;
            this.btnAuthConnect.Text = "Connect";
            this.btnAuthConnect.UseVisualStyleBackColor = true;
            this.btnAuthConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAuthConnection
            // 
            this.lblAuthConnection.AutoSize = true;
            this.lblAuthConnection.Location = new System.Drawing.Point(249, 187);
            this.lblAuthConnection.Name = "lblAuthConnection";
            this.lblAuthConnection.Size = new System.Drawing.Size(0, 13);
            this.lblAuthConnection.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAuthConnection);
            this.Controls.Add(this.btnAuthConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthConnect;
        private System.Windows.Forms.Label lblAuthConnection;
        private System.Windows.Forms.Button button1;
    }
}

