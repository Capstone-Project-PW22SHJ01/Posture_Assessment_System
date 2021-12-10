using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Media;

namespace PASys
{
    public partial class frmDashboard : Form
    {
        Process myProcess = new Process();
        public frmDashboard()
        {
            InitializeComponent();
            noOfLines = 0;
            myProcess.StartInfo.FileName = "PythonApplication1.exe";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;

            /*
            if (!File.Exists("button_maping.txt"))
            {
                string bMapings = "button1" + "=" + button1.Enabled.ToString() + "\n";
                bMapings += "button2" + "=" + button2.Enabled.ToString() + "\n";
                bMapings += "capbtn" + "=" + capbtn.Enabled.ToString() + "\n";
                bMapings += "btnStart" + "=" + btnStart.Enabled.ToString() + "\n";
                bMapings += "stpbtn" + "=" + stpbtn.Enabled.ToString() + "\n";
                bMapings += "timer1" + "=" + timer1.Enabled.ToString() + "\n";
                bMapings += "timer2" + "=" + timer2.Enabled.ToString() + "\n";
                File.WriteAllText("button_maping.txt", bMapings);
                
            }
            else
            {
                File.WriteAllText("button_maping.txt", string.Empty);
            }
            */
            /*
            string bMapings = "button1" + "=" + button1.Enabled.ToString() + "\n";
            bMapings += "button2" + "=" + button2.Enabled.ToString() + "\n";
            bMapings += "capbtn" + "=" + capbtn.Enabled.ToString() + "\n";
            bMapings += "btnStart" + "=" + btnStart.Enabled.ToString() + "\n";
            bMapings += "stpbtn" + "=" + stpbtn.Enabled.ToString() + "\n";
            bMapings += "timer1" + "=" + timer1.Enabled.ToString() + "\n";
            bMapings += "timer2" + "=" + timer2.Enabled.ToString() + "\n";
            File.WriteAllText("button_maping.txt", bMapings);
            */
            string[] lines = File.ReadAllLines("button_maping.txt");

            string[] s;
            //MessageBox.Show("I am here! " + lines[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (string line in lines)
            {
                s = line.Split('=');
                //MessageBox.Show("I am here! " + s[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (s[0])
                {
                    case "button1":
                        button1.Enabled = bool.Parse(s[1]);
                        break;
                    case "button2":
                        button2.Enabled = bool.Parse(s[1]);
                        break;
                    case "capbtn":
                        capbtn.Enabled = bool.Parse(s[1]);
                        break;
                    case "btnStart":
                        btnStart.Enabled = bool.Parse(s[1]);
                        break;
                    case "stpbtn":
                        stpbtn.Enabled = bool.Parse(s[1]);
                        break;
                    case "timer1":
                        timer1.Enabled = bool.Parse(s[1]);
                        break;
                    case "timer2":
                        timer2.Enabled = bool.Parse(s[1]);
                        break;
                    default:
                        MessageBox.Show("Button Maping Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            lines = File.ReadAllLines("settings.txt");
            //MessageBox.Show("I am here! " + lines[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (string line in lines)
            {
                s = line.Split('=');
                //MessageBox.Show("I am here! " + s[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (s[0] == "timerVal")
                {
                    timer4.Interval = int.Parse(s[1]) * 60 * 1000;
                }

            }




            string path = "log.txt";
            if (new FileInfo(path).Length != 0)
            {
                var lastLine = File.ReadLines(path).Last();
                s = lastLine.Split(':');
                s = s[0].Split(" ");

                DateTime yesterday = DateTime.Parse(s[0]);
                if (yesterday < DateTime.Today)
                {
                    if (File.Exists(path))
                    {
                        File.Move("log.txt", yesterday.ToString("ddMMyyyy") + ".txt");
                    }
                }
            }



            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            lines = File.ReadAllLines(path);


            int vals;
            int countOf0 = 0;
            int count = 0;
            foreach (string line in lines)
            {
                s = line.Split(':');
                vals = Int16.Parse(s[3].Trim());
                if (vals == 0)
                {
                    countOf0++;
                    count++;
                }
                else if (vals == 1)
                {
                    count++;
                }

            }
            /*
            label6.Text = (countOf0 * 10).ToString() + " Sec";
            float pers = (float)countOf0 / (float)count;
            lines = File.ReadAllLines("settings.txt");

            float nordic = 0;
            */

            /*
             * (x[0.5] * age/100 + y[0.1] * neck + z[0.1] * shoulder + a[0.1] * elbow + b[0.1] * UB + c[0.1] * LB)
             * 
             */
            //MessageBox.Show("I am here! " + lines[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            /*
            foreach (string line in lines)
            {
                s = line.Split('=');
                //MessageBox.Show("I am here! " + s[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(s[0] == "ageVal")
                {
                    nordic += (0.5f * float.Parse(s[1]) / 100.0f);
                    continue;
                }
                bool bVal = bool.Parse(s[1]);
                nordic += (0.1f * Convert.ToInt16(bVal));

            }*/
            /*
            //MessageBox.Show("Nordic Value " + nordic.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (pers >= (0.9 - (0.2 * nordic)))
            {
                label7.Text = "High Risk";
                
            }
            else if (pers >= (0.75 - (0.2 * nordic)))
            {
                label7.Text = "Medium Risk";
            }
            else if (pers >= (0.5 - (0.2 * nordic)))
            {
                label7.Text = "Low Risk";
            }*/

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        FilterInfoCollection filterInfoCollection2;
        VideoCaptureDevice videoCaptureDevice2;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (pic.Image != null)
            {
                pic.Image.Dispose();
            }
            pic.Image = (Bitmap)eventArgs.Frame.Clone();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (btnStart.Enabled == true)
            {
                Process[] procList = Process.GetProcesses();

                for (int i = 0; i < procList.Length; i++)
                {
                    if (procList[i].ProcessName.ToString() == "PythonApplication1")
                    {
                        procList[i].Kill();
                    }
                }
                capbtn.Enabled = true;
                myProcess.Start();
                timer5.Enabled = true;
                update_buttons(capbtn.Name, capbtn.Enabled.ToString());
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

                videoCaptureDevice.Start();
                btnStart.Enabled = false;
                update_buttons(btnStart.Name, btnStart.Enabled.ToString());
                button1.Enabled = false;
                update_buttons(button1.Name, button1.Enabled.ToString());
            }

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            if(cboCamera.Items.Count <= 0)
            {
                MessageBox.Show("No camera detected or camera access denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            cboCamera.SelectedIndex = 0;
            

            videoCaptureDevice = new VideoCaptureDevice();

            filterInfoCollection2 = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection2)
                trackbox.Items.Add(filterInfo.Name);
            //if (trackbox.Items.Count > 0)
            {
                trackbox.SelectedIndex = 0;
            }
            //trackbox.SelectedIndex = 0;
            videoCaptureDevice2 = new VideoCaptureDevice();

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void capbtn_Click(object sender, EventArgs e)
        {
            if (btnStart.Enabled == false)
            {
                if (videoCaptureDevice.IsRunning == true)
                {
                    if (capbox.Image != null)
                    {
                        capbox.Image.Dispose();
                    }
                    capbox.Image = (Bitmap)pic.Image.Clone();
                    capbox.Image.Save("image.jpg");
                    //newbackg.Save(@"Resources\image.jpg");
                    /*
                    input.ImageSource = "image.jpg";
                    ModelOutput result = ConsumeModel.Predict(input);
                    File.Delete("image.jpg");
                    MessageBox.Show("IP % = " + result.Score[0].ToString() + " P % = " + result.Score[1].ToString(), result.Prediction, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    */
                }

                else
                {

                    MessageBox.Show("Please start the camera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void capbox_Click(object sender, EventArgs e)
        {

        }

        private void stpbtn_Click(object sender, EventArgs e)
        {
            capbtn.Enabled = false;
            update_buttons(capbtn.Name, capbtn.Enabled.ToString());
            if (capbox.Image != null)
            {
                capbox.Image.Dispose();
            }
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
                pic.Image = null;
                capbox.Image = null;

            }
            Process[] procList = Process.GetProcesses();
            for (int i = 0; i < procList.Length; i++)
            {
                if (procList[i].ProcessName.ToString() == "PythonApplication1")
                {
                    procList[i].Kill();
                }
            }
            button1.Enabled = true;
            update_buttons(button1.Name, button1.Enabled.ToString());
            btnStart.Enabled = true;
            update_buttons(btnStart.Name, btnStart.Enabled.ToString());
            timer5.Enabled = false;
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        Bitmap backg = null;
        Bitmap newbackg = null;

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("log.txt");

            string[] s;
            int vals;
            int countOf0 = 0;
            int count = 0;

            DateTime now = DateTime.Now;
            now = now.AddHours(-1);


            string[] ks;
            foreach (string line in lines)
            {
                s = line.Split(':');
                ks = line.Split(' ');
                DateTime temp = DateTime.ParseExact(ks[0] + " " + ks[1], "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture);

                if (temp <= now)
                {
                    //label7.Text = "True";
                    vals = Int16.Parse(s[3].Trim());
                    if (vals == 0)
                    {
                        countOf0++;
                        count++;
                    }
                    else if (vals == 1)
                    {
                        count++;
                    }

                }

            }

            float pers = (float)countOf0 / (float)count;
            if (pers >= 0.5)
            {
                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "You've been in improper posture for long time, check the app for stats", ToolTipIcon.Info);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice2.IsRunning == true)
            {
                if (newbackg != null)
                {
                    newbackg.Dispose();
                }

                newbackg = (Bitmap)backg.Clone();
                newbackg.Save("image.jpg");

                string[] lines = File.ReadAllLines("log.txt");

                string[] s;
                int vals;
                int countOf0 = 0;
                int count = 0;
                foreach (string line in lines)
                {
                    s = line.Split(':');
                    vals = Int16.Parse(s[3].Trim());
                    if (vals == 0)
                    {
                        countOf0++;
                        count++;
                    }
                    else if (vals == 1)
                    {
                        count++;
                    }

                }
                label6.Text = (countOf0 * 10).ToString() + " Sec";
                //newbackg.Save(@"Resources\image.jpg");
                /*
                input.ImageSource = "image.jpg";
                ModelOutput result = ConsumeModel.Predict(input);
                File.Delete("image.jpg");
                MessageBox.Show("Prediction = ", result.Prediction, MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
                /*
                if (capbox.Image != null)
                {
                    capbox.Image.Dispose();
                }
                */
                //capbox.Image = (Bitmap)backg.Clone();





                /*
                float pers = (float)countOf0 / (float)count;
                if(pers >= 0.9)
                {
                    label7.Text = "High Risk";
                }else if(pers >= 0.75)
                {
                    label7.Text = "Medium Risk";
                }else if(pers >= 0.5)
                {
                    label7.Text = "Low Risk";
                }
                */

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();

            for (int i = 0; i < procList.Length; i++)
            {
                if (procList[i].ProcessName.ToString() == "PythonApplication1")
                {
                    procList[i].Kill();
                }
            }
            if (btnStart.Enabled == true)
            {

                myProcess.Start();
                button2.Enabled = true;
                update_buttons(button2.Name, button2.Enabled.ToString());
                if (button1.Enabled == true)
                {
                    button1.Enabled = false;
                    update_buttons(button1.Name, button1.Enabled.ToString());
                    videoCaptureDevice2 = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                    videoCaptureDevice2.NewFrame += VideoCaptureDevice_NewFrame2;

                    videoCaptureDevice2.Start();

                }
                btnStart.Enabled = false;
                update_buttons(btnStart.Name, btnStart.Enabled.ToString());
                timer1.Enabled = true;
                update_buttons("timer1", timer1.Enabled.ToString());
                timer2.Enabled = true;
                update_buttons("timer2", timer2.Enabled.ToString());
            }

            else
            {
                MessageBox.Show("Please stop the preview before Tracking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void VideoCaptureDevice_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            if (backg != null)
            {
                backg.Dispose();
            }
            backg = (Bitmap)eventArgs.Frame.Clone();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            update_buttons("timer1", timer1.Enabled.ToString());
            //myProcess.Kill(true);
            /*
            Process[] procList = Process.GetProcesses();
            for (int i = 0; i < procList.Length; i++)
            {
                if (procList[i].ProcessName.ToString() == "PythonApplication1")
                {
                    //a += "Process ID=" + procList[i].Id + "\t" + "Process Name = "+procList[i].ProcessName+"\n";
                    procList[i].Kill();
                }
            }
            */
            if (videoCaptureDevice2.IsRunning == true)
            {
                videoCaptureDevice2.SignalToStop();
                backg = null;

            }
            button1.Enabled = true;
            update_buttons(button1.Name, button1.Enabled.ToString());
            btnStart.Enabled = true;
            update_buttons(btnStart.Name, btnStart.Enabled.ToString());

            Application.Restart();


        }

        private void trackbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void update_buttons(string button_name, string button_value)
        {
            string bMapings = "button1" + "=" + button1.Enabled.ToString() + "\n";
            bMapings += "button2" + "=" + button2.Enabled.ToString() + "\n";
            bMapings += "capbtn" + "=" + capbtn.Enabled.ToString() + "\n";
            bMapings += "btnStart" + "=" + btnStart.Enabled.ToString() + "\n";
            bMapings += "stpbtn" + "=" + stpbtn.Enabled.ToString() + "\n";
            bMapings += "timer1" + "=" + timer1.Enabled.ToString() + "\n";
            bMapings += "timer2" + "=" + timer2.Enabled.ToString() + "\n";
            File.WriteAllText("button_maping.txt", bMapings);
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("log.txt");

            string[] s;
            int vals;
            int countOf0 = 0;
            int count = 0;
            foreach (string line in lines)
            {
                s = line.Split(':');
                vals = Int16.Parse(s[3].Trim());
                if (vals == 0)
                {
                    countOf0++;
                    count++;
                }
                else if (vals == 1)
                {
                    count++;
                }

            }
            label6.Text = (countOf0 * 10).ToString() + " Sec";
            float pers = (float)countOf0 / (float)count;

            lines = File.ReadAllLines("settings.txt");
            float nordic = 0;
            /*
             * (x[0.5] * age/100 + y[0.1] * neck + z[0.1] * shoulder + a[0.1] * elbow + b[0.1] * UB + c[0.1] * LB)
             * 
             */
            //MessageBox.Show("I am here! " + lines[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (string line in lines)
            {
                s = line.Split('=');
                //MessageBox.Show("I am here! " + s[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (s[0] == "ageVal")
                {
                    nordic += (0.5f * float.Parse(s[1]) / 100.0f);
                    continue;
                }
                if (s[0] == "timerVal")
                {
                    continue;
                }
                bool bVal = bool.Parse(s[1]);
                nordic += (0.1f * Convert.ToInt16(bVal));

            }
            //MessageBox.Show("Nordic Value " + nordic.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (pers >= (0.9 - (0.2 * nordic)))
            {
                label7.Text = "High Risk";

            }
            else if (pers >= (0.75 - (0.2 * nordic)))
            {
                label7.Text = "Medium Risk";
            }
            else if (pers >= (0.5 - (0.2 * nordic)))
            {
                label7.Text = "Low Risk";
            }
        }

        private void tick4(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("log.txt");

            string[] s;
            int vals;
            int countOf0 = 0;
            int count = 0;
            foreach (string line in lines)
            {
                s = line.Split(':');
                vals = Int16.Parse(s[3].Trim());
                if (vals == 0)
                {
                    countOf0++;
                    count++;
                }
                else if (vals == 1)
                {
                    count++;
                }

            }
            label6.Text = (countOf0 * 10).ToString() + " Sec";
            float pers = (float)countOf0 / (float)count;

            lines = File.ReadAllLines("settings.txt");
            float nordic = 0;
            /*
             * (x[0.5] * age/100 + y[0.1] * neck + z[0.1] * shoulder + a[0.1] * elbow + b[0.1] * UB + c[0.1] * LB)
             * 
             */
            //MessageBox.Show("I am here! " + lines[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (string line in lines)
            {
                s = line.Split('=');
                //MessageBox.Show("I am here! " + s[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (s[0] == "ageVal")
                {
                    nordic += (0.5f * float.Parse(s[1]) / 100.0f);
                    continue;
                }
                if (s[0] == "timerVal")
                {
                    continue;
                }
                bool bVal = bool.Parse(s[1]);
                nordic += (0.1f * Convert.ToInt16(bVal));

            }
            //MessageBox.Show("Nordic Value " + nordic.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (pers >= (0.9 - (0.2 * nordic)))
            {

                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "cyberpunk_notify.wav";
                player.Play();

                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "Warning HIGH RISK IMPROPER POSTURE!", ToolTipIcon.Info);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;

            }
            else if (pers >= (0.75 - (0.2 * nordic)))
            {
                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "You've been in improper posture for long time, please adjust your posture!", ToolTipIcon.Info);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
            else if (pers >= (0.5 - (0.2 * nordic)))
            {
                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "You are doing well, keep the POSTURE up!", ToolTipIcon.Info);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("log.txt");

            string[] s;
            int vals;
            int countOf0 = 0;
            int count = 0;
            foreach (string line in lines)
            {
                s = line.Split(':');
                vals = Int16.Parse(s[3].Trim());
                if (vals == 0)
                {
                    countOf0++;

                }
                else if (vals == 1)
                {
                    count++;
                }

            }
            MessageBox.Show("Proper count =  " + count.ToString() + " Improper count = " + countOf0.ToString(), "Prediction count", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int noOfLines;
        private void timer5_tick(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("log.txt");

            string[] s;
            int vals;
            int countOf0 = 0;
            int count = 0;
            int tempCount = 0;
            int PorIP = 0;
            foreach (string line in lines)
            {
                s = line.Split(':');
                vals = Int16.Parse(s[3].Trim());
                if (vals == 0)
                {
                    countOf0++;
                    count++;

                }
                else if (vals == 1)
                {
                    count++;
                }
                tempCount++;
                if (tempCount == lines.Length)
                {
                    PorIP = vals;
                }

            }
            label6.Text = (countOf0 * 10).ToString() + " Sec";
            if (noOfLines < count)
            {
                if(noOfLines == 0)
                {
                    noOfLines = count;
                }
                else if (PorIP == 1 )
                {
                    noOfLines = count;
                    MessageBox.Show("You are sitting in Proper posture" , "Prediction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    noOfLines = count;
                    MessageBox.Show("You are sitting in Improper posture", "Prediction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                noOfLines = count;
            }
        }
    }
}
