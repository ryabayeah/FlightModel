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
            if(!timer1.Enabled)
            {
                flight = new Flight(
                        (double)nHeight.Value,
                        (double)nSpeed.Value, 
                        (double)nAngle.Value, 
                        (double)nSize.Value, 
                        (double)nWeight.Value
                        );

                btnStopContinue.Text = "Stop";
                chartFlight.Series[0].Points.Clear();
                chartFlight.Series[0].Points.AddXY(flight.x, flight.y);

                chartFlight.ChartAreas[0].AxisX.Maximum = flight.CalculateMaxDistance();
                chartFlight.ChartAreas[0].AxisY.Maximum = flight.CalculateMaxHeight();

                timer1.Start();
                btnStopContinue.Enabled = true;
                btnStopContinue.BackColor = SystemColors.ButtonFace;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lableTime.Text = "Time: " + flight.timer++ + " sec";
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

    public class Flight
    {
        const double dt = 0.01, g = 9.81, c = 0.15, rho = 1.29;
        public double x, y, t, a, alpha;
        public double s, m, k;
        public double y0, v0;
        public double vx, vy, v;
        public bool state = true;
        public int timer = 0;
        public Flight(double height, double speed, double angle,double size,double weight)
        {
            y0 = height;
            v0 = speed;
            x = 0;
            y = y0;
            t = 0;
            a = angle;
            alpha = a * Math.PI / 180;
            s = size;
            m = weight;
            k = 0.5 * c * rho * s / m;
            vx = v0 * Math.Sin(a * Math.PI / 180);
            vy = v0 * Math.Cos(a * Math.PI / 180);
            state = true;
            timer = 0;
            
        }

        public void CalculateCoordinates()
        {
            v = (double)Math.Sqrt((double)(vx * vx + vy * vy));
            t += dt;
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;

        }
        private double CalculateMaxTime() { return (v0 * Math.Sin(alpha) + Math.Sqrt(Math.Pow(v0 * Math.Sin(alpha), 2) + 2 * g * y0)) / g; }
        public double CalculateMaxHeight() { return Math.Round(y0 + v0 * v0 * Math.Pow(Math.Sin(alpha), 2) / (2 * g), 2) + 0.2; }
        public double CalculateMaxDistance() { return Math.Round(CalculateMaxTime() * v0 * Math.Cos(alpha), 2) + 0.2; }

    }
}


