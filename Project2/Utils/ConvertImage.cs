using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Project2.Utils
{
    public static class ConvertImage
    {
        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, GetImageFormat(img));
                img.Dispose();
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
            return null;
        }

        //public string SetImagePath()
        //{
        //    if (txtImagePath.Text != "")
        //    {
        //        return Path.Combine(@"G:\Tools\Visual Studio\Windows Form\Project2\Resources\Images\",
        //                        Path.GetFileName(txtImagePath.Text));
        //    }
        //    else return null;
        //}

        //public void CopyImageToFolder()
        //{
        //    if (txtImagePath.Text.Trim() != "" || txtImagePath.Text.Length > 0)
        //    {
        //        File.Copy(txtImagePath.Text.Trim(),
        //                Path.Combine(@"G:\Tools\Visual Studio\Windows Form\Project2\Resources\Images\",
        //                Path.GetFileName(txtImagePath.Text)),
        //                false);
        //    }
        //}
    }
}
