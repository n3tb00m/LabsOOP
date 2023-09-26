using Lab2_2.Controls;
using Lab2_2.Services;

namespace Lab2_2.Shapes
{
    internal class Line : Shape
    {
        private Line() { }
        public Line(Point start)
        {
            startPoint = start;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(PaintManager.Instance.Pen, startPoint, endPoint);
        }
    }
}
