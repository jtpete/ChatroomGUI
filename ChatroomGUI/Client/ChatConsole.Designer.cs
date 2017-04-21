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
            this.ClientMessages.Location = new System.Drawing.Point(12, 457);
            this.ClientMessages.Name = "ClientMessages";
            this.ClientMessages.Size = new System.Drawing.Size(490, 22);
            this.ClientMessages.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(427, 485);
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
            this.ChatMessages.Size = new System.Drawing.Size(490, 374);
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
            // ChatConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 517);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.ChatMessages);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ClientMessages);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.ChatName);
            this.Name = "ChatConsole";
            this.Text = "Chatroom";
            this.Load += new System.EventHandler(this.ChatConsole_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ChatConsole_FormClosed);
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
    }
}

