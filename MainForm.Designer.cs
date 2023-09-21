namespace Lab2_2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip1 = new StatusStrip();
            positionStatusLabel = new ToolStripStatusLabel();
            imageSizeStatusLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            saveasMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pencilButton = new Button();
            imageList1 = new ImageList(components);
            lineButton = new Button();
            ellipseButton = new Button();
            rectangleButton = new Button();
            colorPickerButton = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            topArea = new Panel();
            colorDialog = new ColorDialog();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { positionStatusLabel, imageSizeStatusLabel });
            statusStrip1.Location = new Point(0, 633);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1220, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // positionStatusLabel
            // 
            positionStatusLabel.Name = "positionStatusLabel";
            positionStatusLabel.Size = new Size(50, 17);
            positionStatusLabel.Text = "position";
            // 
            // imageSizeStatusLabel
            // 
            imageSizeStatusLabel.Margin = new Padding(10, 3, 0, 2);
            imageSizeStatusLabel.Name = "imageSizeStatusLabel";
            imageSizeStatusLabel.Size = new Size(59, 17);
            imageSizeStatusLabel.Text = "imagesize";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1220, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.Transparent;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem, saveMenuItem, saveasMenuItem, toolStripSeparator1, quitMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(48, 20);
            toolStripMenuItem1.Text = "Файл";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newMenuItem.Size = new Size(173, 22);
            newMenuItem.Text = "Новий";
            newMenuItem.Click += newMenuItem_Click;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openMenuItem.Size = new Size(173, 22);
            openMenuItem.Text = "Відкрити";
            openMenuItem.Click += openMenuItem_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveMenuItem.Size = new Size(173, 22);
            saveMenuItem.Text = "Зберегти...";
            saveMenuItem.Click += saveMenuItem_Click;
            // 
            // saveasMenuItem
            // 
            saveasMenuItem.Name = "saveasMenuItem";
            saveasMenuItem.Size = new Size(173, 22);
            saveasMenuItem.Text = "Зберегти як...";
            saveasMenuItem.Click += saveasMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // quitMenuItem
            // 
            quitMenuItem.Name = "quitMenuItem";
            quitMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitMenuItem.Size = new Size(173, 22);
            quitMenuItem.Text = "Вийти";
            quitMenuItem.Click += quitMenuItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pencilButton);
            flowLayoutPanel1.Controls.Add(lineButton);
            flowLayoutPanel1.Controls.Add(ellipseButton);
            flowLayoutPanel1.Controls.Add(rectangleButton);
            flowLayoutPanel1.Controls.Add(colorPickerButton);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Location = new Point(0, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3);
            flowLayoutPanel1.Size = new Size(71, 134);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pencilButton
            // 
            pencilButton.ImageIndex = 1;
            pencilButton.ImageList = imageList1;
            pencilButton.Location = new Point(3, 3);
            pencilButton.Margin = new Padding(0);
            pencilButton.Name = "pencilButton";
            pencilButton.Size = new Size(32, 32);
            pencilButton.TabIndex = 3;
            pencilButton.UseVisualStyleBackColor = true;
            pencilButton.Click += pencilButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "line.png");
            imageList1.Images.SetKeyName(1, "pencil.png");
            imageList1.Images.SetKeyName(2, "ellipse.png");
            imageList1.Images.SetKeyName(3, "rectangle.png");
            // 
            // lineButton
            // 
            lineButton.ImageIndex = 0;
            lineButton.ImageList = imageList1;
            lineButton.Location = new Point(35, 3);
            lineButton.Margin = new Padding(0);
            lineButton.Name = "lineButton";
            lineButton.Size = new Size(32, 32);
            lineButton.TabIndex = 4;
            lineButton.UseVisualStyleBackColor = true;
            lineButton.Click += lineButton_Click;
            // 
            // ellipseButton
            // 
            ellipseButton.ImageIndex = 2;
            ellipseButton.ImageList = imageList1;
            ellipseButton.Location = new Point(3, 35);
            ellipseButton.Margin = new Padding(0);
            ellipseButton.Name = "ellipseButton";
            ellipseButton.Size = new Size(32, 32);
            ellipseButton.TabIndex = 5;
            ellipseButton.UseVisualStyleBackColor = true;
            ellipseButton.Click += ellipseButton_Click;
            // 
            // rectangleButton
            // 
            rectangleButton.ImageIndex = 3;
            rectangleButton.ImageList = imageList1;
            rectangleButton.Location = new Point(35, 35);
            rectangleButton.Margin = new Padding(0);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(32, 32);
            rectangleButton.TabIndex = 6;
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += rectangleButton_Click;
            // 
            // colorPickerButton
            // 
            colorPickerButton.BackColor = Color.Black;
            colorPickerButton.ImageList = imageList1;
            colorPickerButton.Location = new Point(3, 67);
            colorPickerButton.Margin = new Padding(0);
            colorPickerButton.Name = "colorPickerButton";
            colorPickerButton.Size = new Size(32, 32);
            colorPickerButton.TabIndex = 7;
            colorPickerButton.TabStop = false;
            colorPickerButton.UseVisualStyleBackColor = false;
            colorPickerButton.Click += colorPickerButton_Click;
            // 
            // button6
            // 
            button6.ImageList = imageList1;
            button6.Location = new Point(35, 67);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(32, 32);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.ImageList = imageList1;
            button7.Location = new Point(3, 99);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(32, 32);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.ImageList = imageList1;
            button8.Location = new Point(35, 99);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(32, 32);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Зображення (*.bmp, *.jpeg, *.jpg, *.png)|*.bmp;*.jpeg;*.jpg;*.png";
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "Новий малюнок";
            saveFileDialog.Filter = "Зображення (*.bmp, *.jpeg, *.jpg, *.png)|*.bmp;*.jpeg;*.jpg;*.png";
            saveFileDialog.InitialDirectory = "C:\\Users\\work\\Pictures";
            saveFileDialog.FileOk += saveFileDialog1_FileOk;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Anchor = AnchorStyles.Bottom;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(74, 614);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(1122, 16);
            hScrollBar1.TabIndex = 4;
            hScrollBar1.Visible = false;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vScrollBar1.LargeChange = 1;
            vScrollBar1.Location = new Point(1200, 31);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(16, 577);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Visible = false;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // topArea
            // 
            topArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            topArea.Location = new Point(74, 31);
            topArea.Name = "topArea";
            topArea.Size = new Size(1120, 575);
            topArea.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 655);
            Controls.Add(topArea);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "PepePaints";
            Load += MainForm_Load;
            KeyUp += MainForm_KeyUp;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel positionStatusLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem saveasMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button pencilButton;
        private ImageList imageList1;
        private Button lineButton;
        private Button ellipseButton;
        private Button rectangleButton;
        private Button colorPickerButton;
        private Button button6;
        private Button button7;
        private Button button8;
        private ToolStripMenuItem newMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Panel topArea;
        private ToolStripStatusLabel imageSizeStatusLabel;
        private ColorDialog colorDialog;
    }
}