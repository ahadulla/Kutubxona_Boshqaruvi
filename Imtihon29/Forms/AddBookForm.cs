using System;
using System.Windows.Forms;

namespace Imtihon29.Forms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void ImportImagBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ImportImagBtn.Text = ofd.FileName;
        }

        private void CenselBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriceTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PageTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CountTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameTBox.Text;
                string author = AuthorTBox.Text;
                double price = double.Parse(PriceTBox.Text);
                int pageCount = int.Parse(PageTBox.Text);
                int count = int.Parse(CountTBox.Text);
                string imagepath = ImportImagBtn.Text;
                string ebout = EboutLb.Text;
                if (imagepath == "Import")
                {
                    imagepath = string.Empty;
                }
                if (name.Length > 0 && author.Length > 0)
                {
                    Imtihon29.Program.AddBook(name, author, price, pageCount, count, imagepath, ebout);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("Enter the information correctly", "Warning!");
            }
        }

    }
}
