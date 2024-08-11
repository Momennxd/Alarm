using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class clsTimer
        {
            public byte _Seconds;
            public byte _Minutes;
            public byte _Hours;

            public clsTimer(byte Seconds, byte Minutes, byte Hours)
            {
                _Seconds = Seconds;
                _Minutes = Minutes;
                _Hours = Hours;
            }

        }

        clsTimer toTime;
        clsTimer CurrentTime = new clsTimer(0, 0, 0);
        
        int GetTotalSeconds()
        {
            int TotalSeconds = ((toTime._Seconds) + (toTime._Minutes * 60) + (toTime._Hours * 3600));
            return TotalSeconds;

        }

        int TotalSeconds = 0;     
        bool IsTimeOver()
        {
            if (CurrentTime._Hours == toTime._Hours
                && CurrentTime._Minutes == toTime._Minutes
                && CurrentTime._Seconds == toTime._Seconds)
            {
                return true;
            }

            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            byte toSeconds = (((byte)nudSeconds.Value));
            byte toMinutes = ((byte)nudMinutes.Value);
            byte toHours = ((byte)nudHours.Value);
              
            toTime = new clsTimer(toSeconds, toMinutes, toHours);

            if (toTime._Hours == 0 && toTime._Minutes == 0 && toTime._Seconds == 0)
            {
                MessageBox.Show("Please Set A Time.");
                return;
            }

            TotalSeconds = GetTotalSeconds();
            progressBar1.Maximum = TotalSeconds;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;       
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //to update the timer.
            CurrentTime._Seconds++;
            lblSeconds.Text = CurrentTime._Seconds.ToString();
            lblMinutes.Text = CurrentTime._Minutes.ToString();
            lblHours.Text = CurrentTime._Hours.ToString();

            if (CurrentTime._Minutes != 59 && CurrentTime._Seconds == 60)
            {

                CurrentTime._Seconds = 0;
                lblSeconds.Text = CurrentTime._Seconds.ToString();
                CurrentTime._Minutes++;
                lblMinutes.Text = CurrentTime._Minutes.ToString();


            }

            if (CurrentTime._Minutes == 59 && CurrentTime._Seconds == 60)
            {
                CurrentTime._Seconds = 0;
                CurrentTime._Minutes = 0;

                lblSeconds.Text = CurrentTime._Seconds.ToString();
                lblMinutes.Text = CurrentTime._Minutes.ToString();

                CurrentTime._Hours++;
                lblHours.Text = CurrentTime._Hours.ToString();

            }

            
            //to update the progress bar, total seconds = number of steps.      
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;                      
                progressBar1.Refresh();              
            }
           

           
            //to stop the time if it is over.
            if (IsTimeOver())
            {
                timer1.Enabled = false;
                MessageBox.Show("Time Is Up!");               
                btnStart.Enabled = false;
                nudHours.Enabled = false;
                nudMinutes.Enabled = false;
                nudSeconds.Enabled = false;

            }

            

        }

        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            toTime._Seconds = 0;
            toTime._Minutes = 0;
            toTime._Hours = 0;

            nudHours.Value = 0;
            nudMinutes.Value = 0;
            nudSeconds.Value = 0;

            CurrentTime._Seconds = 0;
            CurrentTime._Minutes = 0;
            CurrentTime._Hours = 0;

            lblHours.Text = "0";
            lblMinutes.Text = "0";
            lblSeconds.Text = "0";

            timer1.Enabled = false;

            btnStart.Enabled = true;
            nudHours.Enabled = true;
            nudMinutes.Enabled = true;
            nudSeconds.Enabled = true;

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 0;      
            progressBar1.Refresh();
           

        }
    }
}
