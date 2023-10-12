using System.Drawing.Imaging;

namespace Lab2_2.Services
{
    internal static class ImageUtils
    {
        public static bool IsImage(string filepath)
        {
            int length = 8;
            int offset = 0;

            byte[] filesign = new byte[length];
            byte[] imagesigns = { 0xFF, 0xD8, 0xFF, 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x42, 0x4D };

            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                if (fs.Length < 2) return false;

                switch (Path.GetExtension(filepath))
                {
                    case ".jpg":
                    case ".jpeg":
                        {
                            offset = 0;
                            length = 3;

                            fs.Read(filesign, 0, length);

                            break;
                        }
                    case ".bmp":
                        {
                            offset = 11;
                            length = 2;

                            fs.Read(filesign, 0, length);

                            break;
                        }
                    case ".png":
                        {
                            offset = 3;
                            length = 8;

                            fs.Read(filesign, 0, length);

                            break;
                        }
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (filesign[i] != imagesigns[i + offset]) return false;
            }

            return true;
        }

        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();

            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }

            return null;
        }
    }
}
