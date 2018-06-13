using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FaceDetection
{
    public partial class Camera : Form
    {
        private VideoCapture _capture;
        public Camera()
        {
            InitializeComponent();
            _capture = new VideoCapture();                     
        }

        public IImage GetImage()
        {
            imgCamUser.Image = _capture.QueryFrame();
            CvInvoke.Flip(imgCamUser.Image, imgCamUser.Image, Emgu.CV.CvEnum.FlipType.Horizontal);
            return imgCamUser.Image;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void camera_Load(object sender, EventArgs e)
        {

        }
    }
}
