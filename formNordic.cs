using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASys
{
    public partial class formNordic : Form
    {
        public formNordic()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("settings.txt");

            string[] s;
            //MessageBox.Show("I am here! " + lines[0], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (string line in lines)
            {
                s = line.Split('=');
                //MessageBox.Show("I am here! " + s[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                switch (s[0])
                {
                    case "ageVal":
                        ageVal.Value = int.Parse(s[1]);
                        break;
                    case "neckCheck":
                        neckCheck.Checked = bool.Parse(s[1]);
                        break;
                    case "shouCheck":
                        shouCheck.Checked = bool.Parse(s[1]);
                        break;
                    case "elbowCheck":
                        elbowCheck.Checked = bool.Parse(s[1]);
                        break;
                    case "ubCheck":
                        ubCheck.Checked = bool.Parse(s[1]);
                        break;
                    case "lbCheck":
                        lbCheck.Checked = bool.Parse(s[1]);
                        break;
                    case "timerVal":
                        timerVal.Value = int.Parse(s[1]);
                        break;
                    default:
                        MessageBox.Show("Button Maping Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "ageVal" + "=" + ageVal.Value.ToString() + "\n";
            s += "neckCheck" + "=" + neckCheck.Checked.ToString() + "\n";
            s += "shouCheck" + "=" + shouCheck.Checked.ToString() + "\n";
            s += "elbowCheck" + "=" + elbowCheck.Checked.ToString() + "\n";
            s += "ubCheck" + "=" + ubCheck.Checked.ToString() + "\n";
            s += "lbCheck" + "=" + lbCheck.Checked.ToString() + "\n";
            s += "timerVal" + "=" + timerVal.Value.ToString() + "\n";

            File.WriteAllText("settings.txt", s);
            string message = "Your settings have been updated!";
            string title = "CP2077";
            MessageBox.Show(message, title);
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "cyberpunk_notify.wav";
            player.Play();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void neckCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
