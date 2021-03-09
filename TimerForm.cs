using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

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
        int timerOneTicks = 120;
        int timerTwoTicks = 120;
        
        SoundPlayer alertSound1 = new(Separation_Timer.Properties.Resources.beep);
        SoundPlayer alertSound2 = new(Separation_Timer.Properties.Resources.beep);

        // Form Init

        public TimerForm()
        {
            InitializeComponent();
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

        // =======================
        // Section One
        // =======================

        private void toggleButtonsOne(bool show)
        {
            if (show)
            {
                buttonTimerOne1.Visible = true;
                buttonTimerOne2.Visible = true;
            }
            else
            {
                buttonTimerOne1.Visible = false;
                buttonTimerOne2.Visible = false;
            }

            alertSound1.Stop();
        }

        private void buttonTimerOne1_Click(object sender, EventArgs e)
        {
            timerOne.Enabled = true;
            timerOneTicks = 120;
            labelTimeOne.Text = "02:00";

            toggleButtonsOne(false);
        }

        private void buttonTimerOne2_Click(object sender, EventArgs e)
        {
            timerOne.Enabled = true;
            timerOneTicks = 180;
            labelTimeOne.Text = "03:00";

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
            }
            else
            {
                buttonTimerTwo1.Visible = false;
                buttonTimerTwo2.Visible = false;
            }

            alertSound2.Stop();
        }

        private void buttonTimerTwo1_Click(object sender, EventArgs e)
        {
            timerTwo.Enabled = true;
            timerTwoTicks = 120;
            labelTimeTwo.Text = "02:00";

            toggleButtonsTwo(false);
        }

        private void buttonTimerTwo2_Click(object sender, EventArgs e)
        {
            timerTwo.Enabled = true;
            timerTwoTicks = 180;
            labelTimeTwo.Text = "03:00";

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
