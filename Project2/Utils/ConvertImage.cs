using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Project2.Utils
{
    class ConvertImage
    {
        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, GetImageFormat(img));
                return ms.ToArray();
            }
        }

        public static Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public static ImageFormat GetImageFormat(Image img)
        {
            if (ImageFormat.Jpeg.Equals(img.RawFormat))
            {
                return ImageFormat.Jpeg;
            }
            else if (ImageFormat.Png.Equals(img.RawFormat))
            {
                return ImageFormat.Png;
            }
            else return ImageFormat.Bmp;
        }
    }
}
