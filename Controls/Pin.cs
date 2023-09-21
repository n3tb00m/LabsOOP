namespace Lab2_2.Controls
{
    public enum PinPosition
    {
        Bottom = 1,
        Right = 2,
    }

    internal class Pin : Control
    {
        private PinPosition _pinPosition;
        public bool horizontal = false;
        public bool vertical = false;
        private Point dragStartPoint;

        public Pin(Control prnt, PinPosition position)
        {
            Parent = prnt;
            Size = new Size(5, 5);
            _pinPosition = position;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Lime;

            switch (_pinPosition)
            {
                case PinPosition.Right:
                    {
                        Location = new Point(Parent.Width - Size.Width,
                            Parent.Height / 2 - Size.Width / 2);

                        Anchor = AnchorStyles.Right;
                        horizontal = true;

                        break;
                    }
                case PinPosition.Bottom:
                    {
                        Location = new Point(Parent.Width / 2 - Size.Width / 2,
                            Parent.Height - Size.Height);

                        Anchor = AnchorStyles.Bottom;
                        vertical = true;
                        break;
                    }
                case PinPosition.Bottom | PinPosition.Right:
                    {
                        Location = new Point(Parent.Width - Size.Width, Parent.Height - Size.Height);

                        Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                        horizontal = true;
                        vertical = true;

                        break;
                    }

            }
;

            SetStyle(ControlStyles.Selectable, false);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragStartPoint = new Point(Cursor.Position.X - e.Location.X, Cursor.Position.Y - e.Location.Y);
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentPoint = new Point(Cursor.Position.X, Cursor.Position.Y);

                int dX = currentPoint.X - dragStartPoint.X;
                int dY = currentPoint.Y - dragStartPoint.Y;

                if (dX < -Parent.Width || dY < -Parent.Height) return;

                if (horizontal) this.Parent.Parent.Width += dX;
                if (vertical) this.Parent.Parent.Height += dY;
            }
        }
    }
}
