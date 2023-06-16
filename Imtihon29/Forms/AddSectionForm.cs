using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Imtihon29.Forms
{
    public partial class AddSectionForm : Form
    {
        public AddSectionForm()
        {
            InitializeComponent();
        }

        //[DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        //public extern static bool ReleaseCapture();
        //[DllImport("User32.dll", EntryPoint = "SendMessage")]
        //public extern static int SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void OnMouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(this.Handle, 0x112, 0xf012, 0);
        //    }
        //}

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = System.Drawing.Color.DarkRed;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Censel_MouseEnter(object sender, EventArgs e)
        {
            CenselBtn.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void Censel_MouseLeave(object sender, EventArgs e)
        {
            CenselBtn.BackColor = System.Drawing.Color.White;
        }

        private void OkBtn_MouseEnter(object sender, EventArgs e)
        {
            OkBtn.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void OkBtn_MouseLeave(object sender, EventArgs e)
        {
            OkBtn.BackColor = System.Drawing.Color.White;
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            string filePath = dlg.FileName;
            ImportBtn.Text = filePath;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            string path = ImportBtn.Text;
            if (path == "Import")
            {
                path = string.Empty;
            }
            string name = NameTBox.Text;
            if (name.Length > 0)
            {
                Imtihon29.Program.AddSection(name, path);
            }
            this.Close();
        }
    }
}
