namespace Lab2_2
{
    public partial class MainForm : Form
    {
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int dx = (dWidth) / (100 - horizontalScrollPercentage);

            bottomArea.Location = new Point(-e.NewValue * dx, bottomArea.Location.Y);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double dy = (double)dHeight / (100 - verticalScrollPercentage);

            bottomArea.Location = new Point(bottomArea.Location.X, (int)Math.Ceiling((double)-e.NewValue * dy));
        }
    }
}
