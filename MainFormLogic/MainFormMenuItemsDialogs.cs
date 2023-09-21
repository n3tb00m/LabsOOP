using Lab2_2.Controls;
using Lab2_2.Services;

namespace Lab2_2
{
    public partial class MainForm : Form
    {
        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (path != string.Empty)
            {
                SaveFile(path);
            }
            else
            {
                saveFileDialog.ShowDialog();
            }
        }

        private void saveasMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            bottomArea.Size = defaultSize;

            bottomArea.Image = new Bitmap(bottomArea.Size.Width, bottomArea.Size.Height);

            bottomArea.Location = Point.Empty;

            Graphics.FromImage(bottomArea.Image).Clear(Color.White);

            PaintManager.Instance.ResetGraphics();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ImageUtils.IsImage(openFileDialog.FileName))
            {
                codecInfo = ImageUtils.GetEncoderInfo($"image/{Path.GetExtension(openFileDialog.FileName)[1..]}");

                bottomArea.Image = Image.FromFile(openFileDialog.FileName);
                bottomArea.Size = bottomArea.Image.Size;
                //topArea.Size = bottomArea.Size;

                path = openFileDialog.FileName;

                PaintManager.Instance.ResetGraphics();

                statusStrip1.BringToFront();

            }
            else MessageBox.Show("Файл пошкоджений або не є зображенням.");
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFile(saveFileDialog.FileName);

            path = saveFileDialog.FileName;
        }

        private void SaveFile(string savepath)
        {
            string ext = Path.GetExtension(savepath)[1..];
            if (ext == "jpg") ext = "jpeg";
            codecInfo = ImageUtils.GetEncoderInfo($"image/{ext}");

            bottomArea.Image.Save(savepath, codecInfo, null);
        }
    }
}
