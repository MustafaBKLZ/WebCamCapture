using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCam_Capture;

namespace WebCameraCapture
{
    public partial class AnaMenu : Form
    {
        WebCam webcam;


        public AnaMenu() { InitializeComponent(); }


        private void AnaMenu_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref img_Web_Cam);
        }
        private void btn_Baslat_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }
        private void btn_Durdur_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }
        private void btn_Devam_Et_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }
        private void btn_Resim_Cek_Click(object sender, EventArgs e)
        {
            img_Alinan_Resim.Image = img_Web_Cam.Image;
            tabControl1.SelectedIndex = 1;
        }
        private void btn_Resmi_Kaydet_Click(object sender, EventArgs e)
        {
            Helper.SaveImageCapture(img_Alinan_Resim.Image);
        }
        private void btn_Tekrar_Dene_Click(object sender, EventArgs e)
        {
            webcam.Start();
            tabControl1.SelectedIndex = 0;
        }
    }
}
