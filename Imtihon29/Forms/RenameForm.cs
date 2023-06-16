using System;
using System.IO;
using System.Windows.Forms;

namespace Imtihon29.Forms
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (RenameTbox.Text.Length > 0)
            {
                Program.RenameText = RenameTbox.Text;
                var Btn = Imtihon29.MainForm.Btn;
                var SectionList = Imtihon29.Program.SectionList;
                string name = Btn.Text;
                foreach (var item in SectionList)
                {
                    if (item.Name == name)
                    {
                        item.Name = Program.RenameText;
                        File.Move($"C:/IqroData/{name}.json", $"C:/IqroData/{Program.RenameText}.json");
                        break;
                    }
                }
            }
            this.Close();
        }
    }
}
