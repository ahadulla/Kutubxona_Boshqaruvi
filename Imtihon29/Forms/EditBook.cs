using Imtihon29.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imtihon29.Forms
{
    public partial class EditBook : Form
    {
        public int Index { get; set; } = 0;

        public EditBook()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void CenselBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void JoinData(Book book,int inxex)
        {
            Index = inxex;
            this.NameTBox.Text = book.Name;
            this.AuthorTBox.Text = book.Author;
            this.PriceTBox.Text += book.Price;
            this.PageTBox.Text = book.PageCount.ToString();
            this.CountTBox.Text = book.Code.ToString();
            this.EboutLb.Text = book.Ebout;
            Image img = Image.FromFile(book.ImagePath);
            var resize = new Bitmap(img, 140, 220);
            this.ImagePnl.BackgroundImage = resize;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var list = Imtihon29.Program.BookList;
                list[Index].Name = NameTBox.Text;
                list[Index].Author = AuthorTBox.Text;
                list[Index].Price = double.Parse(PriceTBox.Text);
                list[Index].PageCount = int.Parse(PageTBox.Text);
                list[Index].Code = int.Parse(CountTBox.Text);
                list[Index].Ebout = EboutLb.Text;
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
