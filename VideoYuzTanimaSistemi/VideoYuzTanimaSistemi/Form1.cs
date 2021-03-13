using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.Threading;

namespace VideoYuzTanimaSistemi
{
    public partial class Form1 : Form
    {
        #region Veriables
        private Capture capture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool yuzOdaklamaAktifligi = false;
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKameraAc_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Dispose();
            }
            else if (capture == null)
            {
                capture = new Capture();
                capture.ImageGrabbed += ProcressFrame;
                capture.Start();
            }
        }

        private int sayac = 0;
        private void ProcressFrame(object sender, EventArgs e)
        {
            capture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(pbVideo.Width, pbVideo.Height, Inter.Cubic);
            if (yuzOdaklamaAktifligi)
            {
                Mat griResim = new Mat();
                CvInvoke.CvtColor(currentFrame, griResim, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(griResim, griResim);
                Thread.Sleep((int)capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));

                Rectangle[] yuzler = faceCascadeClassifier.DetectMultiScale(griResim, 1.1, 3, Size.Empty, Size.Empty);

                if (yuzler.Length > 0)
                {
                    foreach (var yuz in yuzler)
                    {
                        CvInvoke.Rectangle(currentFrame, yuz, new Bgr(Color.Red).MCvScalar, 2);
                        sayac++;
                    }
                }
            }
            pbVideo.Image = currentFrame.Bitmap;
        }

        private void btnYakala_Click(object sender, EventArgs e)
        {
            if (yuzOdaklamaAktifligi = true)
            {
                lblSayac.Text = sayac.ToString() + " Yüz Tanımlandı";
            }
        }

        private void btnVideoSec_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Dispose();
            }
            else if (capture == null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Video Files |*.mp4";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    capture = new Emgu.CV.Capture(ofd.FileName);
                }
                if (capture != null)
                {
                    capture.ImageGrabbed += ProcressFrame;
                    capture.Start();
                }
            }
        }
    


        //private void Capture_ImageGrabbed(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Mat m = new Mat();
        //        capture.Retrieve(m);
        //        pbVideo.Image = m.ToImage<Bgr, byte>().Bitmap;
        //        Thread.Sleep((int)capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Stop();
            }
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Pause();
            }
        }

    }
}
