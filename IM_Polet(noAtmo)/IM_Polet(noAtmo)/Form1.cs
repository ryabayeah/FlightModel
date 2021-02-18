using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM_Polet_noAtmo_
{

    public partial class Form1 : Form
    {
        Flight flight;
        public Form1()
        {
            InitializeComponent();
            btnStopContinue.Enabled = false;
            btnStopContinue.BackColor = SystemColors.GrayText;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var tuple  = Utils.CheckFields((double)nSpeed.Value, (double)nAngle.Value);
            lableTime.Text = tuple.output;
            if (tuple.pass)
            {
                flight = new Flight((double)nHeight.Value, (double)nSpeed.Value, (double)nAngle.Value);
                btnStopContinue.Text = "Stop";
                chartFlight.Series[0].Points.Clear();
                chartFlight.Series[0].Points.AddXY(flight.x, flight.y);

                var tulpe = flight.CalculateMaxCoordinates();
                chartFlight.ChartAreas[0].AxisX.Maximum = tulpe.X;
                chartFlight.ChartAreas[0].AxisY.Maximum = tulpe.Y;

                timer1.Start();
                btnStopContinue.Enabled = true;
                btnStopContinue.BackColor = SystemColors.ButtonFace;
            }
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lableTime.Text = "Time: " + flight.timer++;
            flight.CalculateCoordinates();
            chartFlight.Series[0].Points.AddXY(flight.x, flight.y);
            if (flight.y <= 0) timer1.Stop();
        }

        private void btnStopContinue_Click(object sender, EventArgs e)
        {
            if (flight.state)
            {
                timer1.Stop();
                btnStopContinue.Text = "Continue";
                flight.state = false;
            }
            else
            {
                timer1.Start();
                btnStopContinue.Text = "Stop";
                flight.state = true;
            }
        }
    }

    public static class Utils
    {
        public static (bool pass,string output) CheckFields(double speed, double angle)
        {
            string output = "";
            (bool pass, string output) t2 = (true, output);
            Dictionary<string, double> Fields = new Dictionary<string, double>
                {
                    {"Speed", speed},
                    {"Angle", angle}
                };
            foreach (var i in Fields)
            {
                if (i.Value <= 0)
                {
                     output = String.Format("Enter value of {0} greater than 0", i.Key);
                    t2 = (false, output);
                    return t2;
                    
                }
            }
            return t2;

        }
    }
    public class Flight
    {
        const double dt = 0.01;
        const double g = 9.81;
        public double x;
        public double y;
        public double t;
        public double a;
        public double y0;
        public double v0;
        public double xMax;
        public double yMax;
        public bool state = true;
        public int timer = 0;


        public Flight(double height, double speed, double angle)
        {
            y0 = height;
            v0 = speed;
            a = angle;
            state = true;
            timer = 0;
            x = 0;
            y = y0;
            t = 0;
        }

        public void CalculateCoordinates()
        {
            t += dt;
            x = v0 * Math.Cos(a * Math.PI / 180) * t;
            y = y0 + v0 * Math.Sin(a * Math.PI / 180) * t - g * t * t / 2;
        }
        public  (double X, double Y) CalculateMaxCoordinates()
        {
            double tMax = (v0 * Math.Sin(a * Math.PI / 180) + Math.Sqrt(Math.Pow(v0 * Math.Sin(a * Math.PI / 180), 2) + 2 * g * y0)) / g;
            double yMax = y0 + Math.Pow(v0 * Math.Sin(a * Math.PI / 180), 2) / (2 * g);
            double xMax = v0 * Math.Cos(a * Math.PI / 180) * tMax;
            double AxisX = Math.Round(xMax, 2) + Math.Round(xMax * 0.2, 3);
            double AxisY = Math.Round(yMax, 2) + Math.Round(yMax * 0.2, 3);
            (double X, double Y)t2 = (AxisX, AxisY);
            return t2;
        }
    }
}


