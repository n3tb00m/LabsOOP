using System.ComponentModel;

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
        private Graphics bottomGraphics = null!;
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

        public void PaintDot(Point p)
        {
            bottomGraphics.FillRectangle(Pen.Brush, p.X - Pen.Width / 2, p.Y - Pen.Width / 2, Pen.Width, Pen.Width);
        }

        public void PaintFigure()
        {
            Point centerPoint = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);

            switch (Type)
            {
                case FigureType.Line:
                    bottomGraphics.DrawLine(Pen, startPoint, endPoint); break;

                case FigureType.Ellipse:
                    bottomGraphics.DrawEllipse(Pen, new Rectangle(centerPoint.X - width / 2, centerPoint.Y - height / 2, width, height)); break;

                case FigureType.Rectangle:
                    bottomGraphics.DrawRectangle(Pen, new Rectangle(centerPoint.X - width / 2, centerPoint.Y - height / 2, width, height)); break;
            }
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
                    {
                        drawingGraphics.DrawLine(Instance.Pen, startPoint, endPoint);
                        break;
                    }

                case FigureType.Ellipse:
                    {
                        Point centerPoint = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
                        int width = Math.Abs(startPoint.X - endPoint.X);
                        int height = Math.Abs(startPoint.Y - endPoint.Y);

                        drawingGraphics.DrawEllipse(Pen, new Rectangle(centerPoint.X - width / 2, centerPoint.Y - height / 2,
                            width, height)); break;
                    }

                case FigureType.Rectangle:
                    {
                        Point centerPoint = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
                        int width = Math.Abs(startPoint.X - endPoint.X);
                        int height = Math.Abs(startPoint.Y - endPoint.Y);


                        drawingGraphics.DrawRectangle(Pen, new Rectangle(centerPoint.X - width / 2, centerPoint.Y - height / 2, width, height)); break;
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
