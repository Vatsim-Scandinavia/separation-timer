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
        SoundPlayer alertSound = new(Separation_Timer.Properties.Resources.beep);

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


        // Section One

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
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonTimerOne1_Click(object sender, EventArgs e)
        {
            timerOne.Enabled = true;
            timerOneTicks = 10;
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

        private void timerOne_Tick(object sender, EventArgs e)
        {

            // Tick
            timerOneTicks--;

            // Play timer sound
            if (timerOneTicks == 1)
            {
                alertSound.Play();
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

    }
}
