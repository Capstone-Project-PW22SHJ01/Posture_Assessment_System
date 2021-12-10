using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASys
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string s = "button1=True\nbutton2=False\ncapbtn=False\nbtnStart=True\nstpbtn=True\ntimer1=False\ntimer2=True\n";
            File.WriteAllText("button_maping.txt", s);
            
            if (!(File.Exists("log.txt")))
            {
                File.CreateText("log.txt");
            }
            if (!(File.Exists("settings.txt")))
            {
                //File.CreateText("settings.txt");
                s = "ageVal" + "=" + "1" + "\n";
                s += "neckCheck" + "=" + "False" + "\n";
                s += "shouCheck" + "=" + "False" + "\n";
                s += "elbowCheck" + "=" + "False" + "\n";
                s += "ubCheck" + "=" + "False" + "\n";
                s += "lbCheck" + "=" + "False" + "\n";
                s += "timerVal" + "=" + "15" + "\n";

                File.WriteAllText("settings.txt", s);
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            
        }
    }
}
