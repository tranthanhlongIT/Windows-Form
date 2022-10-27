using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project2.Utils
{
    public static class ConvertImage
    {
        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
