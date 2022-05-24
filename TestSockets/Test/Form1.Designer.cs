namespace Test
{
    partial class Aplicatie
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
            this.components = new System.ComponentModel.Container();
            this._usernameTextBox = new System.Windows.Forms.TextBox();
            this._chatTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._chatLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._userTextBox = new System.Windows.Forms.TextBox();
            this._sendButton = new System.Windows.Forms.Button();
            this._printMessages = new System.Windows.Forms.Timer(this.components);
            this._quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _usernameTextBox
            // 
            this._usernameTextBox.Location = new System.Drawing.Point(127, 47);
            this._usernameTextBox.Name = "_usernameTextBox";
            this._usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this._usernameTextBox.TabIndex = 0;
            // 
            // _chatTextBox
            // 
            this._chatTextBox.Location = new System.Drawing.Point(56, 150);
            this._chatTextBox.Multiline = true;
            this._chatTextBox.Name = "_chatTextBox";
            this._chatTextBox.Size = new System.Drawing.Size(690, 189);
            this._chatTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username: ";
            // 
            // _chatLabel
            // 
            this._chatLabel.AutoSize = true;
            this._chatLabel.Location = new System.Drawing.Point(60, 134);
            this._chatLabel.Name = "_chatLabel";
            this._chatLabel.Size = new System.Drawing.Size(29, 13);
            this._chatLabel.TabIndex = 3;
            this._chatLabel.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // _userTextBox
            // 
            this._userTextBox.Location = new System.Drawing.Point(56, 362);
            this._userTextBox.Multiline = true;
            this._userTextBox.Name = "_userTextBox";
            this._userTextBox.Size = new System.Drawing.Size(607, 38);
            this._userTextBox.TabIndex = 5;
            // 
            // _sendButton
            // 
            this._sendButton.Location = new System.Drawing.Point(683, 377);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(75, 23);
            this._sendButton.TabIndex = 6;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this.Send);
            // 
            // _printMessages
            // 
            this._printMessages.Enabled = true;
            this._printMessages.Tick += new System.EventHandler(this.ReadMessageEveryTick);
            // 
            // _quitButton
            // 
            this._quitButton.Location = new System.Drawing.Point(683, 415);
            this._quitButton.Name = "_quitButton";
            this._quitButton.Size = new System.Drawing.Size(75, 23);
            this._quitButton.TabIndex = 7;
            this._quitButton.Text = "Quit";
            this._quitButton.UseVisualStyleBackColor = true;
            this._quitButton.Click += new System.EventHandler(this.Quit);
            // 
            // Aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._quitButton);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._userTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._chatLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._chatTextBox);
            this.Controls.Add(this._usernameTextBox);
            this.Name = "Aplicatie";
            this.Text = "Aplicatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _usernameTextBox;
        private System.Windows.Forms.TextBox _chatTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _chatLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _userTextBox;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Timer _printMessages;
        private System.Windows.Forms.Button _quitButton;
    }
}

