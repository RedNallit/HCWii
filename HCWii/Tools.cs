using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HCWii
{
    class Tools
    {
        public static void saveFile(string path, Image file)
        {
            file.Save(path,System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public static Image openFile(string path)
        {
            return Bitmap.FromFile(path);
        }



    }
}
