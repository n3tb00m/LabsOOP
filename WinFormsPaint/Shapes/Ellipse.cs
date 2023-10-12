using Lab2_2.Services;

namespace Lab2_2.Shapes
{
    internal class Ellipse : Shape
    {
        private int width;
        private int height;

        private Ellipse() { }
        public Ellipse(Point start)
        {
            startPoint = start;
        }

        public override void Draw(Graphics graphics)
        {
            Point centerPoint = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
            width = Math.Abs(startPoint.X - endPoint.X);
            height = Math.Abs(startPoint.Y - endPoint.Y);

            graphics.DrawEllipse(PaintManager.Instance.Pen, new Rectangle(centerPoint.X - width / 2, centerPoint.Y - height / 2, width, height));
        }
    }
}
