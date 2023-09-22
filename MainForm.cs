using System.Drawing.Imaging;
using System.Windows.Forms;
using Lab2_2.Controls;
using Lab2_2.Services;

namespace Lab2_2
{
    public partial class MainForm : Form
    {
        private bool isDragging = false;

        private PictureBox bottomArea = null!;
        private TransparentContainer container = null!;

        private string path = string.Empty;
        private ImageCodecInfo codecInfo = null!;

        private Bitmap currentImage = null!;

        private Size defaultSize = new Size(1120, 575);
        private Point location = new Point(74, 31);

        private int verticalScrollPercentage;
        private int horizontalScrollPercentage;
        private int dWidth;
        private int dHeight;

        public MainForm()
        {
            InitializeComponent();

            InitializeDrawing();
        }

        private void InitializeDrawing()
        {

            bottomArea = new DrawingArea(topArea, defaultSize, Point.Empty);
            bottomArea.SizeMode = PictureBoxSizeMode.Normal;

            bottomArea.SizeChanged += bottomArea_SizeChanged;

            bottomArea.Image = new Bitmap(bottomArea.Size.Width, bottomArea.Size.Height);

            Graphics.FromImage(bottomArea.Image).Clear(Color.White);

            container = new TransparentContainer(bottomArea, new Size(defaultSize.Width,
                defaultSize.Height), Point.Empty);

            container.MouseDown += container_MouseDown;
            container.MouseUp += container_MouseUp;
            container.MouseMove += container_MouseMove;

            PaintManager.Instance.SetPanels(container, bottomArea);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            positionStatusLabel.Text = "";
            imageSizeStatusLabel.Text = string.Format("{0} px, {1} px", bottomArea.Size.Width, bottomArea.Size.Height);
            colorPickerButton.BackColor = PaintManager.Instance.Pen.Color;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P: pencilButton.PerformClick(); break;
                case Keys.R: rectangleButton.PerformClick(); break;
                case Keys.E: ellipseButton.PerformClick(); break;
                case Keys.L: lineButton.PerformClick(); break;
            }
        }
    }
}