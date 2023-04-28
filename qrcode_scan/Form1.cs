using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace qrcode_scan
{
    public partial class Form1 : Form
    {

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public Form1()
        {
            InitializeComponent();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBox1.Items.Add(Device.Name);
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(bitmap);
            if (pictureBox1.Image != null)
            {
                
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                }
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
