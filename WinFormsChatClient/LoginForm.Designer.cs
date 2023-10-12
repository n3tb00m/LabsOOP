namespace WinFormsChatClient
{
    partial class LoginForm
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
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            connectButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(36, 37);
            nameTextBox.MaxLength = 16;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 32);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 6);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 77);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 3;
            label2.Text = "Chat password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(36, 108);
            passwordTextBox.MaxLength = 16;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(159, 32);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // connectButton
            // 
            connectButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            connectButton.Location = new Point(56, 154);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(119, 42);
            connectButton.TabIndex = 4;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(234, 211);
            Controls.Add(connectButton);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private Button connectButton;
    }
}