using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASys
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {

            //chart 1
            ChartSeries series = new ChartSeries("todays", ChartSeriesType.Pie);
            string[] lines = File.ReadAllLines("log.txt");

            ChartSeries series2 = new ChartSeries("past4days", ChartSeriesType.Pie);

            if (lines.Length == 0)
            {
                series.Points.Add("Improper", 0);
                //series.LegendName = "Hello";

                series.Points.Add("Proper", 0);
                //series.LegendName = "Hello";
                this.chartControl1.Series.Add(series);

                series2.Points.Add("Improper", 0);

                series2.Points.Add("Proper", 0);


                this.chartControl2.Series.Add(series2);
                return;
            }

            string[] s;
            int vals;
            int countOf0 = 0;
            int countOf1 = 0;
            foreach (string line in lines)
            {
                s = line.Split(':');
                vals = Int16.Parse(s[3].Trim());
                if(vals == 0)
                {
                    countOf0++;
                }else if(vals == 1)
                {
                    countOf1++;
                }
                
            }

            series.Points.Add("Improper", countOf0);
            //series.LegendName = "Hello";
            
            series.Points.Add("Proper", countOf1);
            //series.LegendName = "Hello";
            this.chartControl1.Series.Add(series);
            

            
            

            //chart 2

            
            DateTime now = DateTime.Today;
            now = now.AddDays(-4);
            countOf0 = 0;
            countOf1 = 0;

            while(now.Date != DateTime.Today)
            {
                s = now.ToString().Split('/');
                s = s[0].Split(' ');
                s = s[0].Split('-');
                string fileName = s[0] + s[1] + s[2] + ".txt";
                if (File.Exists(fileName))
                {
                    lines = File.ReadAllLines(fileName);
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
                            countOf1++;
                        }

                    }
                }

                

                now = now.AddDays(1);
            }
            if (File.Exists("log.txt"))
            {
                lines = File.ReadAllLines("log.txt");
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
                        countOf1++;
                    }

                }
            }
            series2.Points.Add("Improper", countOf0);
            


            series2.Points.Add("Proper", countOf1);
            

            this.chartControl2.Series.Add(series2);

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
