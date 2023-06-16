using Imtihon29.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imtihon29.Forms
{
    public partial class RentForm : Form
    {
        public Book newbook { get; set; }

        public RentForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PentExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fulname = FullnameTBox.Text;
                string pasportData = PassportTBox.Text;
                string phonenum = PnumTBox.Text;
                DateTime delDate = DateTime.ParseExact(DeliveryTBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime retDate = DateTime.ParseExact(ReturnTBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string ebout = EboutTBox.Text;
                Imtihon29.Program.AddRentBook(fulname, pasportData, phonenum, delDate, retDate, ebout, newbook);
                this.Close();
            }
            catch
            {
                DeliveryTBox.Text =string.Empty;
                ReturnTBox.Text = string.Empty;
                MessageBox.Show("Enter the information correctly");
            }
        }

        private void PnumTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void AddImage(Book obj, Image img)
        {
            newbook = obj;
            if (img != null)
            {
                this.ImagePnl.BackgroundImage = img;
            }
        }

        private void DeliveryTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if(DeliveryTBox.Text.Length == 2 || DeliveryTBox.Text.Length == 5)
            {
                DeliveryTBox.Text += "/";
                DeliveryTBox.SelectionStart = DeliveryTBox.Text.Length;
            }
        }

        private void ReturnTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (ReturnTBox.Text.Length == 2 || ReturnTBox.Text.Length == 5)
            {
                ReturnTBox.Text += "/";
                ReturnTBox.SelectionStart = ReturnTBox.Text.Length;
            }
        }
    }


}
