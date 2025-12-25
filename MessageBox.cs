using System;
using System.Threading;
using System.Windows.Forms;

namespace VirtualDisplay
{
    public partial class MessageBox : Form
    {
        public bool result = false;
        private int? timer;
        public MessageBox(string title, string description, bool yes, bool ok, bool no,int? time)
        {
            InitializeComponent();
            DoubleBuffered = true;
            if (yes == true)
            {
                Yes.Visible = true;
            }
            if (no == true)
            {
                No.Visible = true;
            }
            if (ok == true)
            {
                OK.Visible = true;
            }
            this.Name = title;
            label1.Text = title;
            Text.Text = description;
            timer = time;
            if(timer != 0 || timer != null)
            {

                tmp = Text.Text;
                a = 0;
                timer1.Start();
            }
        }

        private bool Close_IsOverlapped;
        private float Close_Opacity = 0f;


        private void App_Close_MouseEnter(object sender, System.EventArgs e)
        {
            Close_IsOverlapped = true;
            Timer_Close_button.Start();
        }

        private void App_Close_MouseLeave(object sender, System.EventArgs e)
        {
            Close_IsOverlapped = false;
            Timer_Close_button.Start();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
                base.Capture = false;
                Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref m);
        }

        private void Timer_Close_button_Tick(object sender, EventArgs e)
        {
            Gradient_Float gf = new Gradient_Float();
            if (Close_IsOverlapped == true)  Close_Opacity += 0.1f;
            else if (Close_IsOverlapped == false)  Close_Opacity -= 0.1f;
            
            if (Close_Opacity >= 1f)
            {
                Close_Opacity = 1f;
                Timer_Close_button.Stop();
            }
            else if (Close_Opacity <= 0f)
            {
                Close_Opacity = 0f;
                Timer_Close_button.Stop();
            }

            App_Close.BackgroundImage = gf.ChangeOpacity(VirtualDisplay.Properties.Resources.hovered, Close_Opacity);
        }

        private void App_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
        private int x, y;
        private void Text_MouseDown_1(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }


        string tmp;
        ushort a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a <= timer)
            {
                Text.Text = tmp + (timer - a) + "секунд(а).";
            }
            else
            {
                this.Close();
            }
        }

        private void MessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void Text_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }
    }
}
