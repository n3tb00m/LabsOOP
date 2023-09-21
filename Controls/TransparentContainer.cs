namespace Lab2_2.Controls
{
    internal class TransparentContainer : Control
    {
        public static readonly Size pinSize = new Size(5, 5);

        public TransparentContainer(Control prnt, Size size, Point loc)
        {
            Size = new Size(size.Width, size.Height);
            Location = new Point(loc.X, loc.Y);
            Parent = prnt;

            Pin right = new Pin(this, PinPosition.Right);

            Pin bottom = new Pin(this, PinPosition.Bottom);

            Pin br = new Pin(this, PinPosition.Bottom | PinPosition.Right);

            SetStyle(ControlStyles.ContainerControl | ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Opaque, false);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            BackColor = Color.Transparent;
        }
    }
}
