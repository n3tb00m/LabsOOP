using System.Drawing.Drawing2D;

namespace Lab2_2.Controls
{

    internal class DrawingArea : PictureBox
    {
        public DrawingArea(Control prnt, Size size, Point location)
        {
            Parent = prnt;
            Size = size;
            Location = location;

            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint (PaintEventArgs e) // тут переробити
        {
            base.OnPaint (e);
        }
    }
}
