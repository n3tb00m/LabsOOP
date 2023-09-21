using Lab2_2.Services;

namespace Lab2_2
{
    public partial class MainForm : Form
    {
        private void pencilButton_Click(object sender, EventArgs e)
        {
            pencilButton.Focus();
            PaintManager.Instance.Type = FigureType.Pencil;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            ellipseButton.Focus();
            PaintManager.Instance.Type = FigureType.Ellipse;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            lineButton.Focus();
            PaintManager.Instance.Type = FigureType.Line;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            rectangleButton.Focus();
            PaintManager.Instance.Type = FigureType.Rectangle;
        }
        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            PaintManager.Instance.Pen.Color = colorDialog.Color;
            colorPickerButton.BackColor = PaintManager.Instance.Pen.Color;
            colorPickerButton.Update();
            container.Focus();
        }
    }
}
