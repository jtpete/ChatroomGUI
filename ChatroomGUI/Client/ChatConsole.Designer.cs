namespace Client
{
    partial class ChatConsole
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
            this.ChatName = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.ClientMessages = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.ChatMessages = new System.Windows.Forms.RichTextBox();
            this.Leave = new System.Windows.Forms.Button();
            this.PrivateMessageToggle = new System.Windows.Forms.CheckBox();
            this.PrivateMessageChatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChatName
            // 
            this.ChatName.Location = new System.Drawing.Point(12, 26);
            this.ChatName.Name = "ChatName";
            this.ChatName.Size = new System.Drawing.Size(246, 22);
            this.ChatName.TabIndex = 0;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(265, 24);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // ClientMessages
            // 
            this.ClientMessages.Location = new System.Drawing.Point(12, 384);
            this.ClientMessages.Name = "ClientMessages";
            this.ClientMessages.Size = new System.Drawing.Size(490, 22);
            this.ClientMessages.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(427, 421);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ChatMessages
            // 
            this.ChatMessages.Location = new System.Drawing.Point(12, 55);
            this.ChatMessages.Name = "ChatMessages";
            this.ChatMessages.Size = new System.Drawing.Size(490, 309);
            this.ChatMessages.TabIndex = 5;
            this.ChatMessages.Text = "";
            // 
            // Leave
            // 
            this.Leave.AutoEllipsis = true;
            this.Leave.Enabled = false;
            this.Leave.Location = new System.Drawing.Point(346, 24);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(75, 23);
            this.Leave.TabIndex = 6;
            this.Leave.Text = "Leave";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // PrivateMessageToggle
            // 
            this.PrivateMessageToggle.AutoSize = true;
            this.PrivateMessageToggle.Location = new System.Drawing.Point(12, 426);
            this.PrivateMessageToggle.Name = "PrivateMessageToggle";
            this.PrivateMessageToggle.Size = new System.Drawing.Size(135, 21);
            this.PrivateMessageToggle.TabIndex = 7;
            this.PrivateMessageToggle.Text = "Private Message";
            this.PrivateMessageToggle.UseVisualStyleBackColor = true;
            this.PrivateMessageToggle.CheckedChanged += new System.EventHandler(this.PrivateMessageToggle_CheckedChanged);
            // 
            // PrivateMessageChatName
            // 
            this.PrivateMessageChatName.Location = new System.Drawing.Point(12, 453);
            this.PrivateMessageChatName.Name = "PrivateMessageChatName";
            this.PrivateMessageChatName.Size = new System.Drawing.Size(246, 22);
            this.PrivateMessageChatName.Enabled = false;
            this.PrivateMessageChatName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chat name to private message";
            // 
            // ChatConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrivateMessageChatName);
            this.Controls.Add(this.PrivateMessageToggle);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.ChatMessages);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ClientMessages);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.ChatName);
            this.Name = "ChatConsole";
            this.Text = "Chatroom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatConsole_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatName;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox ClientMessages;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox ChatMessages;
        private System.Windows.Forms.Button Leave;
        private System.Windows.Forms.CheckBox PrivateMessageToggle;
        private System.Windows.Forms.TextBox PrivateMessageChatName;
        private System.Windows.Forms.Label label1;
    }
}

