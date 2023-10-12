using Lab2_2.Shapes;

namespace Lab2_2.Services
{
    enum FigureType
    {
        Pencil = 0,
        Line = 1,
        Ellipse = 2,
        Rectangle = 3,
    }
    internal class PaintManager
    {
        private static PaintManager _instance = null!;
        public FigureType Type;
        public Pen Pen;
        public Point startPoint;
        public Point endPoint;
        public List<Point> points;
        private Control drawingArea = null!;
        private PictureBox bottomArea = null!;
        private Graphics drawingGraphics = null!;
        public Graphics bottomGraphics = null!;
        private Shape figure;

        public static PaintManager Instance
        {
            get
            {
                if (_instance == null) _instance = new PaintManager();
                return _instance;
            }
        }

        private PaintManager()
        {
            Pen = new Pen(Color.Black);
            Pen.Width = 5;
            Type = FigureType.Pencil;
            endPoint = Point.Empty;
            points = new List<Point>();
        }

        public void SetPanels(Control draw, PictureBox bottom)
        {
            drawingArea = draw;
            bottomArea = bottom;

            drawingGraphics = draw.CreateGraphics();
            bottomGraphics = Graphics.FromImage(bottom.Image);
        }

        public void ResetGraphics()
        {
            drawingGraphics = drawingArea.CreateGraphics();
            bottomGraphics = Graphics.FromImage(bottomArea.Image);
        }

        public void CreateFigure()
        {
            switch (Type)
            {
                case FigureType.Line: figure = new Line(startPoint); break;
                case FigureType.Ellipse: figure = new Ellipse(startPoint); break;
                case FigureType.Rectangle: figure = new Rect(startPoint); break;
            }
        }

        public void PaintDot(Point p)
        {
            bottomGraphics.FillRectangle(Pen.Brush, p.X - Pen.Width / 2, p.Y - Pen.Width / 2, Pen.Width, Pen.Width);
        }

        public void PaintFigure(Graphics g)
        {
            figure.SetEndPoint(endPoint);
            figure.Draw(g);
        }

        public void Paint(Point p)
        {
            switch (Type)
            {
                case FigureType.Pencil:
                    {
                        points.Add(p);
                        if (points.Count > 1) bottomGraphics.DrawLines(Pen, points.ToArray());
                        break;
                    }

                case FigureType.Line:
                case FigureType.Ellipse:
                case FigureType.Rectangle:
                    {
                        PaintFigure(drawingGraphics); break;
                    }
            }
        }

        public void ResetImage(ref Bitmap currentImage)
        {
            currentImage = new Bitmap(bottomArea.Image);

            Bitmap newBitmap = new Bitmap(bottomArea.Size.Width, bottomArea.Size.Height);

            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White);
                g.DrawImage(currentImage, 0, 0);
            }

            bottomArea.Image = newBitmap;
            currentImage = newBitmap;

            bottomArea.Size = bottomArea.Image.Size;
            drawingArea.Size = bottomArea.Size;

            ResetGraphics();
        }
    }
}
