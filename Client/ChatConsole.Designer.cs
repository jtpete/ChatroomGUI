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
            this.ServerConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChatroomText = new System.Windows.Forms.TextBox();
            this.ClientText = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatName
            // 
            this.ChatName.Location = new System.Drawing.Point(12, 25);
            this.ChatName.Name = "ChatName";
            this.ChatName.Size = new System.Drawing.Size(284, 22);
            this.ChatName.TabIndex = 0;
            this.ChatName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ServerConnect
            // 
            this.ServerConnect.Location = new System.Drawing.Point(324, 25);
            this.ServerConnect.Name = "ServerConnect";
            this.ServerConnect.Size = new System.Drawing.Size(108, 23);
            this.ServerConnect.TabIndex = 1;
            this.ServerConnect.Text = "Connect";
            this.ServerConnect.UseVisualStyleBackColor = true;
            this.ServerConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat Name";
            // 
            // ChatroomText
            // 
            this.ChatroomText.Location = new System.Drawing.Point(12, 70);
            this.ChatroomText.Multiline = true;
            this.ChatroomText.Name = "ChatroomText";
            this.ChatroomText.Size = new System.Drawing.Size(545, 338);
            this.ChatroomText.TabIndex = 3;
            // 
            // ClientText
            // 
            this.ClientText.Location = new System.Drawing.Point(12, 442);
            this.ClientText.Name = "ClientText";
            this.ClientText.Size = new System.Drawing.Size(545, 22);
            this.ClientText.TabIndex = 4;
            this.ClientText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(449, 470);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(108, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChatConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 519);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ClientText);
            this.Controls.Add(this.ChatroomText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerConnect);
            this.Controls.Add(this.ChatName);
            this.Name = "ChatConsole";
            this.Text = "Chatroom";
            this.Load += new System.EventHandler(this.ChatConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatName;
        private System.Windows.Forms.Button ServerConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChatroomText;
        private System.Windows.Forms.TextBox ClientText;
        private System.Windows.Forms.Button Submit;
    }
}

