using System;
using System.IO;
using System.Linq;
using System.Text;
using WebCam_Capture;
using System.Collections.Generic;

namespace WebCameraCapture
{
    class WebCam
    {
        private WebCamCapture webcam;
        private System.Windows.Forms.PictureBox _FrameResim;
        private int FrameNo = 30;

        public void InitializeWebCam(ref System.Windows.Forms.PictureBox imgBox)
        {
            webcam = new WebCamCapture();
            webcam.FrameNumber = ((ulong)(0ul));
            webcam.TimeToCapture_milliseconds = FrameNo;
            webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ResimCek);
            _FrameResim = imgBox;
        }
        void webcam_ResimCek(object source, WebcamEventArgs e)
        {
            _FrameResim.Image = e.WebCamImage;
        }
        public void Start()
        {
            webcam.TimeToCapture_milliseconds = FrameNo;
            webcam.Start(0);
        }
        public void Stop()
        {
            webcam.Stop();
        }
        public void Continue()
        {
            webcam.TimeToCapture_milliseconds = FrameNo;
            webcam.Start(this.webcam.FrameNumber);
        }
    }
}
