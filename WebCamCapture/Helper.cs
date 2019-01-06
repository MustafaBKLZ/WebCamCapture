using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WebCameraCapture
{
    class Helper
    {
        public static void SaveImageCapture(System.Drawing.Image image)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Resim_" + DateTime.Now.ToString("dd.MM.yyyy");
            s.DefaultExt = ".jpg";
            s.Filter = "Image (.jpg)|*.jpg";

            if (s.ShowDialog() == DialogResult.OK)
            {
                string DosyaAdi = s.FileName;
                FileStream fstream = new FileStream(DosyaAdi, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
            }
        }
    }
}
