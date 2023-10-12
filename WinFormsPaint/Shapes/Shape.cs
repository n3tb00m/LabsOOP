namespace Lab2_2.Shapes
{
    internal class Shape
    {
        protected Point startPoint;
        protected Point endPoint;

        public virtual void Draw(Graphics g)
        {

        }

        public void SetEndPoint(Point end)
        {
            endPoint = end;
        }
    }
}
