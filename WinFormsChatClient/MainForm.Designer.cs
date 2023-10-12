namespace WinFormsChatClient
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageTextBox = new TextBox();
            sendButton = new Button();
            messagesTextBox = new TextBox();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageTextBox.Location = new Point(5, 526);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(684, 23);
            messageTextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            sendButton.Location = new Point(691, 522);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(87, 33);
            sendButton.TabIndex = 2;
            sendButton.Text = "Відправити";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messagesTextBox
            // 
            messagesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messagesTextBox.BackColor = Color.White;
            messagesTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messagesTextBox.Location = new Point(5, 5);
            messagesTextBox.Multiline = true;
            messagesTextBox.Name = "messagesTextBox";
            messagesTextBox.ReadOnly = true;
            messagesTextBox.ScrollBars = ScrollBars.Vertical;
            messagesTextBox.Size = new Size(773, 515);
            messagesTextBox.TabIndex = 6;
            messagesTextBox.TabStop = false;
            messagesTextBox.Text = "Welcome to the jungle!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(messagesTextBox);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            KeyPreview = true;
            Name = "MainForm";
            Text = "Chat";
            FormClosing += MainForm_FormClosing;
            KeyUp += MainForm_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox messageTextBox;
        private Button sendButton;
        private TextBox messagesTextBox;
    }
}