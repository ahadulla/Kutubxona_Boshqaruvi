using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imtihon29.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        public extern static bool ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public extern static int SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if(EmailTBox.Text=="1" && PasswordTBox.Text == "1")
            {
                this.Close();
            }
            else
            {
                Imtihon29.Program.Checker = false;
                this.Close();
            }
        }

    }
}
