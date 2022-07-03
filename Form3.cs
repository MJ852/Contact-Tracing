using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;

namespace Contact_Tracing
{
    public partial class Form3 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
 
       

        public Form3(Form1 prevForm)
        {
            InitializeComponent();
            

        }

        private void lblContact_Tracing_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (captureDevice is null)
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cbCameraType.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pctrbxScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbCameraType.Items.Add(filterInfo.Name);
                cbCameraType.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pctrbxScan.Image != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pctrbxScan.Image);

                    if (result != null)
                    {
                        try
                        {
                            StreamWriter HealthForm;
                            HealthForm = File.AppendText(@"C:\Users\Joyce Calangian\Documents\MJ\PUP\SUBJECTS\OBJECT ORIENTED PROGRAMMING\Contact Tracing File\Health_Information.txt");
                             
                            HealthForm.WriteLine(result.ToString());
                            HealthForm.Close();

                            timer1.Stop();

                            if (captureDevice.IsRunning)
                            {
                                captureDevice.SignalToStop();
                                captureDevice.WaitForStop();
                            }


                            MessageBox.Show("Thank you for answering! Stay safe!");
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Close();

                        }
                        catch { }
                    }

                }
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }


}

