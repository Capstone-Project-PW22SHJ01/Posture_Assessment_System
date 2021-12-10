using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASys
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
            labelText.Text = "Dashboard";
            this.panelMain.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        frmDashboard FrmDashboard_Vrb;
        private void button1_Click(object sender, EventArgs e)
        {
            labelText.Text = "Dashboard";
            this.panelMain.Controls.Clear();
            FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Make sure that Tracking is Turned Off/Stopped before exiting.\nIf so proceed.";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            //string a = "";
            Process[] procList = Process.GetProcesses();
            for (int i = 0; i < procList.Length; i++)
            {
                if (procList[i].ProcessName.ToString() == "PythonApplication1")
                {
                    //a += "Process ID=" + procList[i].Id + "\t" + "Process Name = "+procList[i].ProcessName+"\n";
                    procList[i].Kill();
                }
            }
            //MessageBox.Show(a);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                Environment.Exit(0);
            }
            else
            {
                // Do something  
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        double[] x = new double[12];
        double[] y = new double[12];

        

        private void formsPlot2_Load(object sender, EventArgs e)
        {
            

            
        }

        private void goView1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelText.Text = "Analytics";
            this.panelMain.Controls.Clear();
            frmAnalytics FrmDashboard_Vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelText.Text = "User Settings";
            this.panelMain.Controls.Clear();
            formNordic FrmDashboard_Vrb = new formNordic() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        bool dragging;
        Point offset;

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {

                Point currentscreenposition = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(currentscreenposition.X - offset.X, currentscreenposition.Y - offset.Y);
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                //notifyIcon1.BalloonTipText = "Important notice High risk posture";
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "App Minimized to system tray", ToolTipIcon.Info);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelText.Text = "About";
            this.panelMain.Controls.Clear();
            frmAboutus FrmDashboard_Vrb = new frmAboutus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
    }
}
