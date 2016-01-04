using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SendKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        // constants for the mouse_input() API function
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int KEY_SHIFT = 0x10;
        private const int KEY_CTRL = 17;
        private const int KEY_ALT = 18;
        private const int START_DELAY = 5000; // 5 seconds

        private int? Event_Down;
        private int? Event_Up;

        private bool _timerEnabled;
        private bool TimerEnabled
        {
            set
            {
                ClickTimer.Enabled = false;
                _timerEnabled = value;
            }
            get
            {
                return _timerEnabled;;
            }
        }


        private void btnPressLeft_Click(object sender, EventArgs e)
        {
            Event_Down = MOUSEEVENTF_LEFTDOWN;
            Event_Up = MOUSEEVENTF_LEFTUP;
            TimerEnabled = true;
            ClickTimer.Interval = Int32.Parse(txtDelay.Text);
        }

        private void btnPressRight_Click(object sender, EventArgs e)
        {
            Event_Down = MOUSEEVENTF_RIGHTDOWN;
            Event_Up = MOUSEEVENTF_RIGHTUP;
            TimerEnabled = true;
            ClickTimer.Interval = Int32.Parse(txtDelay.Text);
        }

        private void btnHoldLeft_Click(object sender, EventArgs e)
        {
            Event_Down = MOUSEEVENTF_LEFTDOWN;
            Event_Up = null;
            TimerEnabled = false;
        }

        private void btnHoldRight_Click(object sender, EventArgs e)
        {
            Event_Down = MOUSEEVENTF_RIGHTDOWN;
            Event_Up = null;
            TimerEnabled = false;
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            if (Event_Down != null) // Why not?
            {
                mouse_event((int) Event_Down, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }
            System.Threading.Thread.Sleep(3);
            if (Event_Up != null)
            {
                mouse_event((int)Event_Up, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(START_DELAY);
            if (TimerEnabled)
            {
                ClickTimer.Enabled = true;
                ClickTimer.Start();
            }
            else
            {
                ClickTimer_Tick(null, null);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ClickTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
