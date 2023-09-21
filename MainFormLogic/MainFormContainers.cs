using Lab2_2.Services;

namespace Lab2_2
{
    public partial class MainForm : Form
    {
        private void container_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;

                PaintManager.Instance.startPoint = e.Location;
                PaintManager.Instance.endPoint = e.Location;
                PaintManager.Instance.points.Add(e.Location);

                if (PaintManager.Instance.Type == FigureType.Pencil)
                {
                    PaintManager.Instance.PaintDot(PaintManager.Instance.startPoint);
                }
            }
        }

        private void container_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button == MouseButtons.Left)
            {
                isDragging = false;
                PaintManager.Instance.PaintFigure();
                container.Refresh();
                PaintManager.Instance.points.Clear();
            }
        }

        private void container_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button == MouseButtons.Left)
            {
                container.Refresh();
                PaintManager.Instance.endPoint = e.Location;
                PaintManager.Instance.Paint(e.Location);
            }

            statusStrip1.Refresh();

            if (e.Location.X >= 0 && e.Location.Y >= 0)
                positionStatusLabel.Text = string.Format("{0} px, {1} px", e.Location.X, e.Location.Y);
        }
        private void bottomArea_SizeChanged(object sender, EventArgs e)
        {
            container.Size = bottomArea.Size;
            container.Location = Point.Empty;
            bottomArea.Location = Point.Empty;

            dWidth = bottomArea.Size.Width - defaultSize.Width;
            dHeight = bottomArea.Size.Height - defaultSize.Height;

            if (dWidth > 0)
            {
                horizontalScrollPercentage = (int)Math.Round((double)defaultSize.Width * 100 / bottomArea.Size.Width);
                hScrollBar1.LargeChange = horizontalScrollPercentage;

                hScrollBar1.Visible = true;
            }
            if (dHeight > 0)
            {
                verticalScrollPercentage = (int)Math.Round((double)defaultSize.Height * 100 / bottomArea.Size.Height);
                vScrollBar1.LargeChange = verticalScrollPercentage;

                vScrollBar1.Visible = true;
            }
            else
            {
                if (dWidth <= 0) hScrollBar1.Visible = false;
                vScrollBar1.Visible = false;
            }

            imageSizeStatusLabel.Text = string.Format("{0} px, {1} px", bottomArea.Size.Width, bottomArea.Size.Height);

            PaintManager.Instance.ResetImage(ref currentImage);
        }
    }
}
