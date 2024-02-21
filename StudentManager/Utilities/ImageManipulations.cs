using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Utilities
{
    public class ImageManipulations
    {

        //byte[]
        public static byte[] GetPhoto(PictureBox pb)
        {
            MemoryStream ms=new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();// getbuffer arry ko byteArray ma convert karta hai        
        }

        
        public static Image PutPhoto(byte[] photo) // hum supply kar rahy hai 
        {
            MemoryStream ms = new MemoryStream(photo);
            // yaha par convert kar rahy hai
            return Image.FromStream(ms);
           
        }
    }
}
