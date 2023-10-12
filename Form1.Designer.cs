namespace Lab1_2
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 63);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 2;
            button1.TabStop = false;
            button1.Text = "+";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnClick;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(58, 63);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 3;
            button2.TabStop = false;
            button2.Text = "-";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnClick;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(106, 63);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.Text = "*";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(106, 109);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 7;
            button4.TabStop = false;
            button4.Text = "/";
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnClick;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(58, 109);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 6;
            button5.TabStop = false;
            button5.Text = "1";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = true;
            button5.Click += OnClick;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(12, 109);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 5;
            button6.TabStop = false;
            button6.Text = "0";
            button6.UseCompatibleTextRendering = true;
            button6.UseVisualStyleBackColor = true;
            button6.Click += OnClick;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(106, 155);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 10;
            button7.TabStop = false;
            button7.Text = "C";
            button7.UseCompatibleTextRendering = true;
            button7.UseVisualStyleBackColor = true;
            button7.Click += OnClick;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(58, 155);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 9;
            button8.TabStop = false;
            button8.Text = ")";
            button8.UseCompatibleTextRendering = true;
            button8.UseVisualStyleBackColor = true;
            button8.Click += OnClick;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(12, 155);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 8;
            button9.TabStop = false;
            button9.Text = "(";
            button9.UseCompatibleTextRendering = true;
            button9.UseVisualStyleBackColor = true;
            button9.Click += OnClick;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.None;
            button10.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(152, 63);
            button10.Name = "button10";
            button10.Size = new Size(40, 86);
            button10.TabIndex = 11;
            button10.TabStop = false;
            button10.Text = "=";
            button10.UseCompatibleTextRendering = true;
            button10.UseVisualStyleBackColor = true;
            button10.Click += OnClick;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.None;
            button11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(152, 155);
            button11.Name = "button11";
            button11.Size = new Size(40, 40);
            button11.TabIndex = 12;
            button11.TabStop = false;
            button11.Text = "AC";
            button11.UseCompatibleTextRendering = true;
            button11.UseVisualStyleBackColor = true;
            button11.Click += OnClick;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.None;
            resultLabel.BorderStyle = BorderStyle.Fixed3D;
            resultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultLabel.Location = new Point(12, 18);
            resultLabel.Name = "resultLabel";
            resultLabel.RightToLeft = RightToLeft.No;
            resultLabel.Size = new Size(180, 32);
            resultLabel.TabIndex = 13;
            resultLabel.Text = "result";
            resultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AcceptButton = button10;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button11;
            ClientSize = new Size(204, 201);
            Controls.Add(resultLabel);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label resultLabel;
    }
}