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

            SetStyle(ControlStyles.Opaque |
                ControlStyles.UserPaint |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnLocationChanged(EventArgs e) // потрібно для плавного переміщення зображення при великих розмірах
        {
            Application.DoEvents();
        }
    }
}
