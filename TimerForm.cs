using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace Separation_Timer
{
    public partial class TimerForm : Form
    {

        // Move window init
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        // Timer init
        int timerOneTicks = 0;
        int timerTwoTicks = 0;

        int defaultTimeOne = 120;
        int defaultTimeTwo = 180;

        SoundPlayer alertSound1 = new(Separation_Timer.Properties.Resources.beep);
        SoundPlayer alertSound2 = new(Separation_Timer.Properties.Resources.beep);

        // Form Init

        public TimerForm()
        {
            InitializeComponent();
            loadSettings();
        }


        private void TimerForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loadSettings()
        {
            try
            {
                string[] lines = File.ReadAllLines("config.cfg");

                for (int i = 0; i < lines.Length; i++)
                {
                    // config.cfg format:
                    // var=value

                    String[] args = lines[i].Split('=');

                    if(args[0] == "one")
                    {
                        defaultTimeOne = Int32.Parse(args[1]) * 60;
                    } else if(args[0] == "two"){
                        defaultTimeTwo = Int32.Parse(args[1]) * 60;
                    }

                }

            }
            catch (FileNotFoundException)
            {
                // Fallback on default
                defaultTimeOne = 120;
                defaultTimeTwo = 180;
            }

            // Set the number on the buttons
            buttonTimerOne1.Text = (defaultTimeOne / 60).ToString();
            buttonTimerTwo1.Text = (defaultTimeOne / 60).ToString();

            buttonTimerOne2.Text = (defaultTimeTwo / 60).ToString();
            buttonTimerTwo2.Text = (defaultTimeTwo / 60).ToString();

        }

        private string secondsToString(int seconds)
        {
            return ((seconds / 60 % 60) >= 10 ? (seconds / 60 % 60).ToString() : "0" + seconds / 60 % 60) + ":"
                     + ((seconds % 60) >= 10 ? (seconds % 60).ToString() : "0" + seconds % 60);
        }

        // =======================
        // Section One
        // =======================

        private void toggleButtonsOne(bool show)
        {
            if (show)
            {
                buttonTimerOne1.Visible = true;
                buttonTimerOne2.Visible = true;
                labelTimeOne.Visible = false;
            }
            else
            {
                buttonTimerOne1.Visible = false;
                buttonTimerOne2.Visible = false;
                labelTimeOne.Visible = true;
            }

            alertSound1.Stop();
        }

        private void buttonTimerOne1_Click(object sender, EventArgs e)
        {
            timerOne.Enabled = true;
            timerOneTicks = defaultTimeOne;
            labelTimeOne.Text = secondsToString(defaultTimeOne);

            toggleButtonsOne(false);
        }

        private void buttonTimerOne2_Click(object sender, EventArgs e)
        {
            timerOne.Enabled = true;
            timerOneTicks = defaultTimeTwo;
            labelTimeOne.Text = secondsToString(defaultTimeTwo);

            toggleButtonsOne(false);

        }

        private void labelTimeOne_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                timerOne.Enabled = false;
                labelTimeOne.Text = "00:00";
                toggleButtonsOne(true);
            }
        }

        private void timerOne_Tick(object sender, EventArgs e)
        {

            // Tick
            timerOneTicks--;

            // Play timer sound
            if (timerOneTicks == 0)
            {
                alertSound1.Play();
            }

            // Color label when five seconds left
            if (timerOneTicks < 6)
            {
                labelTimeOne.ForeColor = Color.Orange;
            }
            else
            {
                labelTimeOne.ForeColor = Color.White;
            }


            // Stop timer if finished or format current time
            if (timerOneTicks < 0)
            {
                timerOne.Enabled = false;
                labelTimeOne.Text = "00:00";
            }
            else
            {
                labelTimeOne.Text =
                     ((timerOneTicks / 60 % 60) >= 10 ? (timerOneTicks / 60 % 60).ToString() : "0" + timerOneTicks / 60 % 60) + ":"
                     + ((timerOneTicks % 60) >= 10 ? (timerOneTicks % 60).ToString() : "0" + timerOneTicks % 60);

            }

        }


        // =======================
        // Section Two
        // =======================

        private void toggleButtonsTwo(bool show)
        {
            if (show)
            {
                buttonTimerTwo1.Visible = true;
                buttonTimerTwo2.Visible = true;
                labelTimeTwo.Visible = false;
            }
            else
            {
                buttonTimerTwo1.Visible = false;
                buttonTimerTwo2.Visible = false;
                labelTimeTwo.Visible = true;
            }

            alertSound2.Stop();
        }

        private void buttonTimerTwo1_Click(object sender, EventArgs e)
        {
            timerTwo.Enabled = true;
            timerTwoTicks = defaultTimeOne;
            labelTimeTwo.Text = secondsToString(defaultTimeOne);

            toggleButtonsTwo(false);
        }

        private void buttonTimerTwo2_Click(object sender, EventArgs e)
        {
            timerTwo.Enabled = true;
            timerTwoTicks = defaultTimeTwo;
            labelTimeTwo.Text = secondsToString(defaultTimeTwo);

            toggleButtonsTwo(false);
        }

        private void labelTimeTwo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                timerTwo.Enabled = false;
                labelTimeTwo.Text = "00:00";
                toggleButtonsTwo(true);
            }
        }

        private void timerTwo_Tick(object sender, EventArgs e)
        {
            // Tick
            timerTwoTicks--;

            // Play timer sound
            if (timerTwoTicks == 0)
            {
                alertSound2.Play();
            }

            // Color label when five seconds left
            if (timerTwoTicks < 6)
            {
                labelTimeTwo.ForeColor = Color.Orange;
            }
            else
            {
                labelTimeTwo.ForeColor = Color.White;
            }


            // Stop timer if finished or format current time
            if (timerTwoTicks < 0)
            {
                timerTwo.Enabled = false;
                labelTimeTwo.Text = "00:00";
            }
            else
            {
                labelTimeTwo.Text =
                     ((timerTwoTicks / 60 % 60) >= 10 ? (timerTwoTicks / 60 % 60).ToString() : "0" + timerTwoTicks / 60 % 60) + ":"
                     + ((timerTwoTicks % 60) >= 10 ? (timerTwoTicks % 60).ToString() : "0" + timerTwoTicks % 60);

            }
        }

        
    }
}
