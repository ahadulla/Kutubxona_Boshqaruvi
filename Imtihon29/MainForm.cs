using Imtihon29.Forms;
using Imtihon29.Models;
using Imtihon29.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Imtihon29
{
    public partial class MainForm : Form
    {
        public static Button Btn { get; set; }

        public static Button Btn2 { get; set; }

        public bool searchcheck { get; set; } = true;

        public int X { get; set; }

        public int Y { get; set; }

        public MainForm()
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
            try
            {
                Imtihon29.Program.WriteRentBookFile();
                Imtihon29.Program.WriteSectionFile();
                Imtihon29.Program.WriteBookFile(Btn.Text);
            }
            catch
            {
            }
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = System.Drawing.Color.DarkRed;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }
        bool MenuOp = false;
        private void MePnTimer_Tick(object sender, EventArgs e)
        {
            if (MenuOp == false)
            {
                MenuPnl.Width += 10;
                if (MenuPnl.Width == MenuPnl.MaximumSize.Width)
                {
                    MenuOp = true;
                    MePnTimer.Stop();
                }
            }
        }

        private void POpenBtn_Click(object sender, EventArgs e)
        {
            if (MenuPnl.Width == MenuPnl.MinimumSize.Width)
                MePnTimer.Start();
            else
                MePnTimer1.Start();
        }

        private void MePnTimer1_Tick(object sender, EventArgs e)
        {
            if (MenuOp)
            {
                MenuPnl.Width -= 10;
                if (MenuPnl.Width == MenuPnl.MinimumSize.Width)
                {
                    MenuOp = false;
                    MePnTimer1.Stop();
                }
            }
        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            AddSectionForm form = new AddSectionForm();
            form.ShowDialog();
            MoveSections();
        }

        public void MoveSections()
        {
            ScrolPanel.Controls.Clear();
            var SectionList = Imtihon29.Program.SectionList;
            X = 96;
            Y = 66;
            for (int i = 0; i < SectionList.Count; i++)
            {
                string path = SectionList[i].ImagePath;
                Button TempBtn = new Button();
                if (path == string.Empty)
                {
                    path = "ExtraComponent/image.png";
                }
                Image image = Image.FromFile(path);
                Image resizeimage = new Bitmap(image, 180, 260);
                TempBtn.Image = resizeimage;
                TempBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                TempBtn.FlatStyle = FlatStyle.Flat;
                TempBtn.Location = new Point(X, Y);
                TempBtn.Size = new Size(180, 260);
                TempBtn.Text = SectionList[i].Name;
                TempBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                TempBtn.UseVisualStyleBackColor = true;
                TempBtn.Click += new System.EventHandler(this.SectionBtn_Click);
                TempBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddSectionBtn_MouseUp);

                this.ScrolPanel.Controls.Add(TempBtn);

                X += 222;
                if (i % 4 == 3)
                {
                    X = 92;
                    Y += 304;
                }
            }
            if (Imtihon29.Program.Checker)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                Button AddSectionBtn = new Button();
                AddSectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                AddSectionBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                AddSectionBtn.ForeColor = System.Drawing.Color.Black;
                AddSectionBtn.Image = Image.FromFile("ExtraComponent/add.png");
                AddSectionBtn.Size = new System.Drawing.Size(180, 260);
                AddSectionBtn.TabIndex = 0;
                AddSectionBtn.Text = "Add section";
                AddSectionBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                AddSectionBtn.UseVisualStyleBackColor = true;
                AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
                AddSectionBtn.Location = new System.Drawing.Point(X, Y);
                ScrolPanel.Controls.Add(AddSectionBtn);
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            
            LogIn logIn = new LogIn();
            logIn.ShowDialog();

            Imtihon29.Program.FillSectionList();
            MoveSections();
            if (!Imtihon29.Program.Checker)
            {
                this.MenuPanel3.Visible = false;
            }
            this.MouseDown += AddSectionBtn_MouseUp;
            Imtihon29.Program.FillRentBookList();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Imtihon29.Program.WriteBookFile(Btn.Text);
            }
            catch
            {
            }
            searchcheck = true;
            Btn = null;
            MoveSections();
        }

        private void AddSectionBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Btn = (Button)sender;
            X = e.X;
            Y = e.Y;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                contextMenuStrip.ForeColor = Color.White;
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Image = Image.FromFile("ExtraComponent/editing.png");
                item.Text = "Rename";
                item.Click += Item_Click;
                contextMenuStrip.Items.Add(item);
                ToolStripMenuItem item1 = new ToolStripMenuItem();
                item1.Image = Image.FromFile("ExtraComponent/replace.png");
                item1.Text = "Chage image";
                item1.Click += Item1_Click;
                contextMenuStrip.Items.Add(item1);
                ToolStripMenuItem item2 = new ToolStripMenuItem();
                item2.Image = Image.FromFile("ExtraComponent/delete.png");
                item2.Text = "Delete";
                item2.Click += Item2_Click;
                contextMenuStrip.Items.Add(item2);
                contextMenuStrip.Show(Btn, X, Y);
            }
        }

        private void Item_Click(Object sender, EventArgs e)
        {
            var SectionList = Imtihon29.Program.SectionList;
            RenameForm renameForm = new RenameForm();
            renameForm.ShowDialog(this);
            MoveSections();
        }

        public void Item1_Click(Object sender, EventArgs e)
        {
            var SectionList = Imtihon29.Program.SectionList;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            string name = Btn.Text;
            foreach (var item in SectionList)
            {
                if (item.Name == name)
                {
                    item.ImagePath = dlg.FileName;
                    break;
                }
            }
            MoveSections();
        }

        public void Item2_Click(Object sender, EventArgs e)
        {
            var SectionList = Imtihon29.Program.SectionList;
            DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                string name = Btn.Text;
                foreach (var item in SectionList)
                {
                    if (item.Name == name)
                    {
                        i = SectionList.IndexOf(item);
                        SectionList.RemoveAt(i);
                        break;
                    }
                }
                MoveSections();
                File.Delete($"C:/IqroData/{name}.json");
            }
        }

        private void SectionBtn_Click(Object sender, EventArgs e)
        {
            Btn = (Button)sender;
            Imtihon29.Program.FillBookList(Btn.Text);
            ScrolPanel.Controls.Clear();
            MoveBooks();
        }

        public void MoveBooks()
        {
            ScrolPanel.Controls.Clear();
            var BookList = Imtihon29.Program.BookList;
            X = 90;
            Y = 66;
            for (int i = 0; i < BookList.Count; i++)
            {
                string path = BookList[i].ImagePath;
                Button TempBtn = new Button();
                if (path == string.Empty)
                {
                    path = "ExtraComponent/image.png";
                }
                try
                {
                    Image image = Image.FromFile(path);
                    Image resizeimage = new Bitmap(image, 120, 200);
                    TempBtn.Image = resizeimage;
                }
                catch
                {
                    Image image = Image.FromFile("ExtraComponent/image.png");
                    Image resizeimage = new Bitmap(image, 120, 200);
                    TempBtn.Image = resizeimage;
                }
                TempBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                TempBtn.FlatStyle = FlatStyle.Flat;
                TempBtn.Location = new Point(X, Y);
                TempBtn.Size = new Size(120, 200);
                TempBtn.Text = BookList[i].Code.ToString();
                TempBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                TempBtn.UseVisualStyleBackColor = true;
                TempBtn.Click += new System.EventHandler(this.EboutBook);
                TempBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookBtn_MouseUp);

                this.ScrolPanel.Controls.Add(TempBtn);
                X += 150;
                if (i % 6 == 5)
                {
                    X = 92;
                    Y += 230;
                }

            }
            if (Imtihon29.Program.Checker)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                Button AddBookBtn = new Button();
                AddBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                AddBookBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                AddBookBtn.ForeColor = System.Drawing.Color.Black;
                AddBookBtn.Image = Image.FromFile("ExtraComponent/add.png");
                AddBookBtn.Size = new System.Drawing.Size(120, 200);
                AddBookBtn.Text = "Add book";
                AddBookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                AddBookBtn.UseVisualStyleBackColor = true;
                AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
                AddBookBtn.Location = new System.Drawing.Point(X, Y);
                ScrolPanel.Controls.Add(AddBookBtn);
            }
            
        }

        private void BookBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Btn2 = (Button)sender;
            X = e.X;
            Y = e.Y;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                contextMenuStrip.ForeColor = Color.White;
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Image = Image.FromFile("ExtraComponent/editing.png");
                item.Text = "Edit";
                item.Click += BookItem_Click;
                contextMenuStrip.Items.Add(item);
                ToolStripMenuItem item1 = new ToolStripMenuItem();
                item1.Image = Image.FromFile("ExtraComponent/replace.png");
                item1.Text = "Chage image";
                item1.Click += BookItem1_Click;
                contextMenuStrip.Items.Add(item1);
                ToolStripMenuItem item2 = new ToolStripMenuItem();
                item2.Image = Image.FromFile("ExtraComponent/delete.png");
                item2.Text = "Delete";
                item2.Click += BookItem2_Click;
                contextMenuStrip.Items.Add(item2);
                contextMenuStrip.Show(Btn2, X, Y);
            }
        }

        public void BookItem_Click(Object sender, EventArgs e)
        {
            int index = 0;
            var list = Imtihon29.Program.BookList;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Code.ToString() == Btn2.Text)
                {
                    index = i;
                }
            }
            EditBook editBook = new EditBook();
            editBook.JoinData(list[index],index);
            editBook.ShowDialog();
            MoveBooks();
        }

        public void BookItem1_Click(Object sender, EventArgs e)
        {
            var BookList = Imtihon29.Program.BookList;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            string text = Btn2.Text;
            foreach (var item in BookList)
            {
                if (item.Code.ToString() == text)
                {
                    item.ImagePath = dlg.FileName;
                    break;
                }
            }
            MoveBooks();
        }

        public void BookItem2_Click(Object sender, EventArgs e)
        {
            var BookList = Imtihon29.Program.BookList;
            DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = 0;
                string text = Btn2.Text;
                foreach (var item in BookList)
                {
                    if (item.Code.ToString() == text)
                    {
                        i = BookList.IndexOf(item);
                        BookList.RemoveAt(i);
                        break;
                    }
                }
                MoveBooks();
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            form.ShowDialog();
            MoveBooks();
        }

        private void LgOBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Show();
        }

        public void RentBtn_Click(object sender, EventArgs e)
        {
            searchcheck = false;
            Btn = null;
            MoveRent();
        }

        public void MoveRent()
        {
            var RentList = Imtihon29.Program.RentList;
            ScrolPanel.Controls.Clear();

            X = 68;
            Y = 72;
            DateTime nowdate = DateTime.Now;
            for(int i = 0;i<RentList.Count;i++)
            {

                Panel panel = new Panel();
                if (RentList[i].Submitted)
                {
                    panel.BackColor = System.Drawing.Color.Green;
                }
                else if (RentList[i].ReturnDate<nowdate && RentList[i].Submitted==false)
                {
                    panel.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    panel.BackColor = System.Drawing.Color.Yellow;
                }
                panel.Location = new System.Drawing.Point(X, Y);
                panel.Name = "panel1";
                panel.Size = new System.Drawing.Size(930, 160);
                panel.TabIndex = 0;

                Panel BImagePnl = new Panel();
                BImagePnl.Dock = System.Windows.Forms.DockStyle.Left;
                BImagePnl.Location = new System.Drawing.Point(0, 0);
                BImagePnl.Name = "BImagePnl";
                BImagePnl.Size = new System.Drawing.Size(140, 200);
                BImagePnl.TabIndex = 7;
                Image img = Image.FromFile(RentList[i].RentBook.ImagePath);
                var resize = new Bitmap(img, 140,200);
                BImagePnl.BackgroundImage = resize; 
                panel.Controls.Add(BImagePnl);

                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label1.Location = new System.Drawing.Point(150, 90);
                label1.ForeColor = System.Drawing.Color.Maroon;
                label1.Name = "label3";
                label1.Size = new System.Drawing.Size(130, 26);
                label1.TabIndex = 10;
                label1.Text = "Book code";
                panel.Controls.Add(label1);

                Label BCodeLb = new Label();
                BCodeLb.AutoSize = true;
                BCodeLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                BCodeLb.Location = new System.Drawing.Point(150, 115);
                BCodeLb.Name = "BCodeLb";
                BCodeLb.Size = new System.Drawing.Size(94, 32);
                BCodeLb.TabIndex = 4;
                BCodeLb.Text = RentList[i].RentBook.Code.ToString();
                panel.Controls.Add(BCodeLb);


                Label label5 = new Label();
                label5.AutoSize = true;
                label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label5.Location = new System.Drawing.Point(150, 19);
                label5.ForeColor = System.Drawing.Color.Maroon;
                label5.Name = "label7";
                label5.Size = new System.Drawing.Size(126, 26);
                label5.TabIndex = 14;
                label5.Text = "Book name";
                panel.Controls.Add(label5);

                Label BNameLb = new Label();
                BNameLb.AutoSize = true;
                BNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                BNameLb.Location = new System.Drawing.Point(150, 45);
                BNameLb.Name = "BNameLb";
                BNameLb.Size = new System.Drawing.Size(178, 32);
                BNameLb.TabIndex = 1;
                BNameLb.Text = RentList[i].RentBook.Name;
                panel.Controls.Add(BNameLb);

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label2.Location = new System.Drawing.Point(630, 90);
                label2.ForeColor = System.Drawing.Color.Maroon;
                label2.Name = "label3";
                label2.Size = new System.Drawing.Size(130, 26);
                label2.TabIndex = 10;
                label2.Text = "Return date";
                panel.Controls.Add(label2);

                Label ReturnLb = new Label();
                ReturnLb.AutoSize = true;
                ReturnLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ReturnLb.Location = new System.Drawing.Point(630, 115);
                ReturnLb.Name = "ReturnLb";
                ReturnLb.Size = new System.Drawing.Size(158, 32);
                ReturnLb.TabIndex = 6;
                ReturnLb.Text = RentList[i].ReturnDate.ToShortDateString();
                panel.Controls.Add(ReturnLb);

                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label3.Location = new System.Drawing.Point(465, 90);
                label3.ForeColor = System.Drawing.Color.Maroon;
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(130, 26);
                label3.TabIndex = 10;
                label3.Text = "Delivery date";
                panel.Controls.Add(label3);

                Label RDelLb = new Label();
                RDelLb.AutoSize = true;
                RDelLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                RDelLb.Location = new System.Drawing.Point(465, 115);
                RDelLb.Name = "RDelLb";
                RDelLb.Size = new System.Drawing.Size(158, 32);
                RDelLb.TabIndex = 2;
                RDelLb.Text = RentList[i].DeleveryDate.ToShortDateString();
                panel.Controls.Add(RDelLb);

                Label label4 = new Label();
                label4.AutoSize = true;
                label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label4.Location = new System.Drawing.Point(300, 90);
                label4.ForeColor = System.Drawing.Color.Maroon;
                label4.Name = "label3";
                label4.Size = new System.Drawing.Size(130, 26);
                label4.TabIndex = 10;
                label4.Text = "Phone nuber";
                panel.Controls.Add(label4);

                Label RPnumLb = new Label();
                RPnumLb.AutoSize = true;
                RPnumLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                RPnumLb.Location = new System.Drawing.Point(300, 115);
                RPnumLb.Name = "RPnumLb";
                RPnumLb.Size = new System.Drawing.Size(158, 32);
                RPnumLb.TabIndex = 5;
                RPnumLb.Text = RentList[i].PhoneNumber;
                panel.Controls.Add(RPnumLb);


                Label label6 = new Label();
                label6.AutoSize = true;
                label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label6.Location = new System.Drawing.Point(730, 19);
                label6.ForeColor = System.Drawing.Color.Maroon;
                label6.Name = "label7";
                label6.Size = new System.Drawing.Size(126, 26);
                label6.TabIndex = 14;
                label6.Text = "Passpotr seria number";
                panel.Controls.Add(label6);

                Label RPseriaLb = new Label();
                RPseriaLb.AutoSize = true;
                RPseriaLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                RPseriaLb.Location = new System.Drawing.Point(750, 45);
                RPseriaLb.Name = "RPseriaLb";
                RPseriaLb.Size = new System.Drawing.Size(164, 32);
                RPseriaLb.TabIndex = 3;
                RPseriaLb.Text = RentList[i].PasportData;
                panel.Controls.Add(RPseriaLb);

                Label label7 = new Label();
                label7.AutoSize = true;
                label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label7.Location = new System.Drawing.Point(400, 19);
                label7.ForeColor = System.Drawing.Color.Maroon;
                label7.Name = "label7";
                label7.Size = new System.Drawing.Size(126, 26);
                label7.TabIndex = 14;
                label7.Text = "Fullname";
                panel.Controls.Add(label7);

                Label RNameLb = new Label();
                RNameLb.AutoSize = true;
                RNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                RNameLb.Location = new System.Drawing.Point(400, 45);
                RNameLb.Name = "RNameLb";
                RNameLb.Size = new System.Drawing.Size(400, 32);
                RNameLb.TabIndex = 2;
                RNameLb.Text = RentList[i].Fullname;
                panel.Controls.Add(RNameLb);

                Button button = new Button();
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Image = Image.FromFile("ExtraComponent/bin.png");
                button.Location = new System.Drawing.Point(870, 95);
                button.Size = new System.Drawing.Size(50, 50);
                button.TabIndex = 0;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(this.button_click);
                panel.Controls.Add(button);
                button.Name = i.ToString();

                Button button2 = new Button();
                button2.FlatAppearance.BorderSize = 0;
                button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button2.Image = Image.FromFile("ExtraComponent/check3.png");
                button2.Location = new System.Drawing.Point(820, 95);
                button2.Size = new System.Drawing.Size(50, 50);
                button2.TabIndex = 0;
                button2.UseVisualStyleBackColor = true;
                button2.Click += new System.EventHandler(this.button2_click);
                panel.Controls.Add(button2);
                button2.Name = "b"+i.ToString();

                this.ScrolPanel.Controls.Add(panel);

                Y += 190;
            }

        }

        public void button_click(object sender, EventArgs e)
        {
            var RentList = Imtihon29.Program.RentList;
            Button button = (Button)sender;
            DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < RentList.Count; i++)
                {
                    if (i == int.Parse(button.Name))
                    {
                        RentList.RemoveAt(i);
                        break;
                    }
                }
                MoveRent();
            }
        }

        public void button2_click(object sender, EventArgs e)
        {
            var RentList = Imtihon29.Program.RentList;
            Button button = (Button)sender;
            DialogResult result = MessageBox.Show("Can you confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string index = button.Name;
                string index1 = index.Substring(1);
                for (int i = 0; i < RentList.Count; i++)
                {
                    if (i == int.Parse(index1))
                    {
                        RentList[i].Submitted = true;
                        break;
                    }
                }
                MoveRent();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string search = searchTBox.Text;
                if (Btn == null && searchcheck)
                {
                    List<SectionClass> list = new List<SectionClass>();
                    var SectionList = Imtihon29.Program.SectionList;
                    for (int i = 0; i < SectionList.Count; i++)
                    {
                        if (SectionList[i].Name.Contains(search))
                        {
                            list.Add(SectionList[i]);
                        }
                    }
                    ScrolPanel.Controls.Clear();
                    X = 96;
                    Y = 66;
                    for (int i = 0; i < list.Count; i++)
                    {
                        string path = list[i].ImagePath;
                        Button TempBtn = new Button();
                        if (path == string.Empty)
                        {
                            path = "ExtraComponent/image.png";
                        }
                        Image image = Image.FromFile(path);
                        Image resizeimage = new Bitmap(image, 180, 260);
                        TempBtn.Image = resizeimage;
                        TempBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        TempBtn.FlatStyle = FlatStyle.Flat;
                        TempBtn.Location = new Point(X, Y);
                        TempBtn.Size = new Size(180, 260);
                        TempBtn.Text = list[i].Name;
                        TempBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                        TempBtn.UseVisualStyleBackColor = true;
                        TempBtn.Click += new System.EventHandler(this.SectionBtn_Click);
                        TempBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddSectionBtn_MouseUp);

                        this.ScrolPanel.Controls.Add(TempBtn);

                        X += 222;
                        if (i % 4 == 3)
                        {
                            X = 92;
                            Y += 304;
                        }
                    }
                }
                else if(searchcheck)
                {
                    List<Book> blist = new List<Book>();
                    var BookList = Imtihon29.Program.BookList;
                    for (int i = 0; i < BookList.Count; i++)
                    {
                        if (BookList[i].Name.Contains(search))
                        {
                            blist.Add(BookList[i]);
                        }
                    }

                    ScrolPanel.Controls.Clear();
                    X = 90;
                    Y = 66;
                    for (int i = 0; i < blist.Count; i++)
                    {
                        string path = blist[i].ImagePath;
                        Button TempBtn = new Button();
                        if (path == string.Empty)
                        {
                            path = "ExtraComponent/image.png";
                        }
                        try
                        {
                            Image image = Image.FromFile(path);
                            Image resizeimage = new Bitmap(image, 120, 200);
                            TempBtn.Image = resizeimage;
                        }
                        catch
                        {
                            Image image = Image.FromFile("ExtraComponent/image.png");
                            Image resizeimage = new Bitmap(image, 120, 200);
                            TempBtn.Image = resizeimage;
                        }
                        TempBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        TempBtn.FlatStyle = FlatStyle.Flat;
                        TempBtn.Location = new Point(X, Y);
                        TempBtn.Size = new Size(120, 200);
                        TempBtn.Text = blist[i].Code.ToString();
                        TempBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                        TempBtn.UseVisualStyleBackColor = true;
                        TempBtn.Click += new System.EventHandler(this.EboutBook);
                        TempBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookBtn_MouseUp);

                        this.ScrolPanel.Controls.Add(TempBtn);
                        X += 150;
                        if (i % 6 == 5)
                        {
                            X = 92;
                            Y += 230;
                        }

                    }
                }
                else if(Imtihon29.Program.Checker)
                {
                    List<Rent> rents = new List<Rent>();
                    var RentList = Imtihon29.Program.RentList;
                    for (int i = 0; i < RentList.Count; i++)
                    {
                        if (RentList[i].Fullname.Contains(search))
                        {
                            rents.Add(RentList[i]);
                        }
                    }

                    ScrolPanel.Controls.Clear();

                    X = 68;
                    Y = 72;
                    DateTime nowdate = DateTime.Now;
                    for (int i = 0; i < rents.Count; i++)
                    {

                        Panel panel = new Panel();
                        if (rents[i].Submitted)
                        {
                            panel.BackColor = System.Drawing.Color.Green;
                        }
                        else if (rents[i].ReturnDate < nowdate && rents[i].Submitted == false)
                        {
                            panel.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            panel.BackColor = System.Drawing.Color.Yellow;
                        }
                        panel.Location = new System.Drawing.Point(X, Y);
                        panel.Name = "panel1";
                        panel.Size = new System.Drawing.Size(930, 160);
                        panel.TabIndex = 0;

                        Panel BImagePnl = new Panel();
                        BImagePnl.Dock = System.Windows.Forms.DockStyle.Left;
                        BImagePnl.Location = new System.Drawing.Point(0, 0);
                        BImagePnl.Name = "BImagePnl";
                        BImagePnl.Size = new System.Drawing.Size(140, 200);
                        BImagePnl.TabIndex = 7;
                        Image img = Image.FromFile(rents[i].RentBook.ImagePath);
                        var resize = new Bitmap(img, 140, 200);
                        BImagePnl.BackgroundImage = resize;
                        panel.Controls.Add(BImagePnl);

                        Label label1 = new Label();
                        label1.AutoSize = true;
                        label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label1.Location = new System.Drawing.Point(150, 90);
                        label1.ForeColor = System.Drawing.Color.Maroon;
                        label1.Name = "label3";
                        label1.Size = new System.Drawing.Size(130, 26);
                        label1.TabIndex = 10;
                        label1.Text = "Book code";
                        panel.Controls.Add(label1);

                        Label BCodeLb = new Label();
                        BCodeLb.AutoSize = true;
                        BCodeLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        BCodeLb.Location = new System.Drawing.Point(150, 115);
                        BCodeLb.Name = "BCodeLb";
                        BCodeLb.Size = new System.Drawing.Size(94, 32);
                        BCodeLb.TabIndex = 4;
                        BCodeLb.Text = rents[i].RentBook.Code.ToString();
                        panel.Controls.Add(BCodeLb);


                        Label label5 = new Label();
                        label5.AutoSize = true;
                        label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label5.Location = new System.Drawing.Point(150, 19);
                        label5.ForeColor = System.Drawing.Color.Maroon;
                        label5.Name = "label7";
                        label5.Size = new System.Drawing.Size(126, 26);
                        label5.TabIndex = 14;
                        label5.Text = "Book name";
                        panel.Controls.Add(label5);

                        Label BNameLb = new Label();
                        BNameLb.AutoSize = true;
                        BNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        BNameLb.Location = new System.Drawing.Point(150, 45);
                        BNameLb.Name = "BNameLb";
                        BNameLb.Size = new System.Drawing.Size(178, 32);
                        BNameLb.TabIndex = 1;
                        BNameLb.Text = rents[i].RentBook.Name;
                        panel.Controls.Add(BNameLb);

                        Label label2 = new Label();
                        label2.AutoSize = true;
                        label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label2.Location = new System.Drawing.Point(630, 90);
                        label2.ForeColor = System.Drawing.Color.Maroon;
                        label2.Name = "label3";
                        label2.Size = new System.Drawing.Size(130, 26);
                        label2.TabIndex = 10;
                        label2.Text = "Return date";
                        panel.Controls.Add(label2);

                        Label ReturnLb = new Label();
                        ReturnLb.AutoSize = true;
                        ReturnLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ReturnLb.Location = new System.Drawing.Point(630, 115);
                        ReturnLb.Name = "ReturnLb";
                        ReturnLb.Size = new System.Drawing.Size(158, 32);
                        ReturnLb.TabIndex = 6;
                        ReturnLb.Text = rents[i].ReturnDate.ToShortDateString();
                        panel.Controls.Add(ReturnLb);

                        Label label3 = new Label();
                        label3.AutoSize = true;
                        label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label3.Location = new System.Drawing.Point(465, 90);
                        label3.ForeColor = System.Drawing.Color.Maroon;
                        label3.Name = "label3";
                        label3.Size = new System.Drawing.Size(130, 26);
                        label3.TabIndex = 10;
                        label3.Text = "Delivery date";
                        panel.Controls.Add(label3);

                        Label RDelLb = new Label();
                        RDelLb.AutoSize = true;
                        RDelLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        RDelLb.Location = new System.Drawing.Point(465, 115);
                        RDelLb.Name = "RDelLb";
                        RDelLb.Size = new System.Drawing.Size(158, 32);
                        RDelLb.TabIndex = 2;
                        RDelLb.Text = rents[i].DeleveryDate.ToShortDateString();
                        panel.Controls.Add(RDelLb);

                        Label label4 = new Label();
                        label4.AutoSize = true;
                        label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label4.Location = new System.Drawing.Point(300, 90);
                        label4.ForeColor = System.Drawing.Color.Maroon;
                        label4.Name = "label3";
                        label4.Size = new System.Drawing.Size(130, 26);
                        label4.TabIndex = 10;
                        label4.Text = "Phone nuber";
                        panel.Controls.Add(label4);

                        Label RPnumLb = new Label();
                        RPnumLb.AutoSize = true;
                        RPnumLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        RPnumLb.Location = new System.Drawing.Point(300, 115);
                        RPnumLb.Name = "RPnumLb";
                        RPnumLb.Size = new System.Drawing.Size(158, 32);
                        RPnumLb.TabIndex = 5;
                        RPnumLb.Text = rents[i].PhoneNumber;
                        panel.Controls.Add(RPnumLb);


                        Label label6 = new Label();
                        label6.AutoSize = true;
                        label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label6.Location = new System.Drawing.Point(730, 19);
                        label6.ForeColor = System.Drawing.Color.Maroon;
                        label6.Name = "label7";
                        label6.Size = new System.Drawing.Size(126, 26);
                        label6.TabIndex = 14;
                        label6.Text = "Passpotr seria number";
                        panel.Controls.Add(label6);

                        Label RPseriaLb = new Label();
                        RPseriaLb.AutoSize = true;
                        RPseriaLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        RPseriaLb.Location = new System.Drawing.Point(750, 45);
                        RPseriaLb.Name = "RPseriaLb";
                        RPseriaLb.Size = new System.Drawing.Size(164, 32);
                        RPseriaLb.TabIndex = 3;
                        RPseriaLb.Text = rents[i].PasportData;
                        panel.Controls.Add(RPseriaLb);

                        Label label7 = new Label();
                        label7.AutoSize = true;
                        label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        label7.Location = new System.Drawing.Point(400, 19);
                        label7.ForeColor = System.Drawing.Color.Maroon;
                        label7.Name = "label7";
                        label7.Size = new System.Drawing.Size(126, 26);
                        label7.TabIndex = 14;
                        label7.Text = "Fullname";
                        panel.Controls.Add(label7);

                        Label RNameLb = new Label();
                        RNameLb.AutoSize = true;
                        RNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        RNameLb.Location = new System.Drawing.Point(400, 45);
                        RNameLb.Name = "RNameLb";
                        RNameLb.Size = new System.Drawing.Size(400, 32);
                        RNameLb.TabIndex = 2;
                        RNameLb.Text = rents[i].Fullname;
                        panel.Controls.Add(RNameLb);

                        Button button = new Button();
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        button.Image = Image.FromFile("ExtraComponent/bin.png");
                        button.Location = new System.Drawing.Point(870, 95);
                        button.Size = new System.Drawing.Size(50, 50);
                        button.TabIndex = 0;
                        button.UseVisualStyleBackColor = true;
                        button.Click += new System.EventHandler(this.button_click);
                        panel.Controls.Add(button);
                        button.Name = i.ToString();

                        Button button2 = new Button();
                        button2.FlatAppearance.BorderSize = 0;
                        button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        button2.Image = Image.FromFile("ExtraComponent/check3.png");
                        button2.Location = new System.Drawing.Point(820, 95);
                        button2.Size = new System.Drawing.Size(50, 50);
                        button2.TabIndex = 0;
                        button2.UseVisualStyleBackColor = true;
                        button2.Click += new System.EventHandler(this.button2_click);
                        panel.Controls.Add(button2);
                        button2.Name = "b" + i.ToString();

                        this.ScrolPanel.Controls.Add(panel);

                        Y += 190;
                    }




                }
            }
            catch
            {

            }
           



        }
    
        public void EboutBook(object sender ,EventArgs e)
        {
            Btn2 = (Button)sender;
            ScrolPanel.Controls.Clear();
            int index = 0;
            var BookList = Imtihon29.Program.BookList;
            Button button = (Button)sender;
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Code == int.Parse(button.Text))
                {
                    index = i;
                    break;
                }
            }
            Panel ImagePnl = new Panel();
            ImagePnl.Location = new System.Drawing.Point(108, 110);
            ImagePnl.Size = new System.Drawing.Size(140, 220);
            ImagePnl.TabIndex = 50;
            Image img = Image.FromFile(BookList[index].ImagePath);
            var resize = new Bitmap(img, 140, 220);
            ImagePnl.BackgroundImage = resize;
            this.ScrolPanel.Controls.Add(ImagePnl);


            Button BackBtn = new Button();
            BackBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BackBtn.Location = new System.Drawing.Point(88, 500);
            BackBtn.Size = new System.Drawing.Size(110, 36);
            BackBtn.TabIndex = 48;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.ScrolPanel.Controls.Add(BackBtn);


            Button RentBtn = new Button();
            RentBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RentBtn.Location = new System.Drawing.Point(850, 500);
            RentBtn.Size = new System.Drawing.Size(110, 36);
            RentBtn.TabIndex = 47;
            RentBtn.Text = "Rent";
            RentBtn.UseVisualStyleBackColor = true;
            RentBtn.Click += new System.EventHandler(this.BRentBtn_Click);
            this.ScrolPanel.Controls.Add(RentBtn);
           
            
            Label EboutLb = new Label();
            EboutLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EboutLb.Location = new System.Drawing.Point(102, 400);
            EboutLb.Size = new System.Drawing.Size(108, 38);
            EboutLb.TabIndex = 41;
            EboutLb.Text = "Ebout";
            this.ScrolPanel.Controls.Add(EboutLb);
      
            
            Label CountLb = new Label();
            CountLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CountLb.Location = new System.Drawing.Point(300, 332);
            CountLb.Size = new System.Drawing.Size(182, 38);
            CountLb.TabIndex = 40;
            CountLb.Text = "Book Code";
            this.ScrolPanel.Controls.Add(CountLb);
     
            
            Label PageCLb = new Label();
            PageCLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PageCLb.Location = new System.Drawing.Point(300, 280);
            PageCLb.Size = new System.Drawing.Size(182, 38);
            PageCLb.TabIndex = 39;
            PageCLb.Text = "Page Count";
            this.ScrolPanel.Controls.Add(PageCLb);
    
            
            Label PriceLb = new Label();
            PriceLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PriceLb.Location = new System.Drawing.Point(300, 227);
            PriceLb.Name = "PriceLb";
            PriceLb.Size = new System.Drawing.Size(182, 38);
            PriceLb.TabIndex = 38;
            PriceLb.Text = "Price";
            this.ScrolPanel.Controls.Add(PriceLb);
    
            
            Label AuthorLb = new Label();
            AuthorLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AuthorLb.Location = new System.Drawing.Point(300, 168);
            AuthorLb.Size = new System.Drawing.Size(182, 38);
            AuthorLb.TabIndex = 37;
            AuthorLb.Text = "Author";
            this.ScrolPanel.Controls.Add(AuthorLb);
     
            
            Label BnameLb = new Label();
            BnameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BnameLb.Location = new System.Drawing.Point(300, 110);
            BnameLb.Name = "BNaameLb";
            BnameLb.Size = new System.Drawing.Size(182, 38);
            BnameLb.TabIndex = 36;
            BnameLb.Text = "Name";
            this.ScrolPanel.Controls.Add(BnameLb);
      
            
            Label NameLb2 = new Label();
            NameLb2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NameLb2.Location = new System.Drawing.Point(550, 110);
            NameLb2.Size = new System.Drawing.Size(450, 38);
            NameLb2.TabIndex = 51;
            NameLb2.Text = BookList[index].Name;
            this.ScrolPanel.Controls.Add(NameLb2);
    
            
            Label AuthorLb2 = new Label();
            AuthorLb2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AuthorLb2.Location = new System.Drawing.Point(550, 168);
            AuthorLb2.Size = new System.Drawing.Size(450, 38);
            AuthorLb2.TabIndex = 52;
            AuthorLb2.Text = BookList[index].Author;
            this.ScrolPanel.Controls.Add(AuthorLb2);
   
            
            Label PriceLb2 = new Label();
            PriceLb2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PriceLb2.Location = new System.Drawing.Point(550, 227);
            PriceLb2.Size = new System.Drawing.Size(450, 38);
            PriceLb2.TabIndex = 53;
            PriceLb2.Text = BookList[index].Price.ToString();
            this.ScrolPanel.Controls.Add(PriceLb2);
    
            
            Label PageCLb2 = new Label();
            PageCLb2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PageCLb2.Location = new System.Drawing.Point(550, 280);
            PageCLb2.Size = new System.Drawing.Size(450, 38);
            PageCLb2.TabIndex = 54;
            PageCLb2.Text = BookList[index].PageCount.ToString();
            this.ScrolPanel.Controls.Add(PageCLb2);
    
            
            Label CodeLb2 = new Label();
            CodeLb2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CodeLb2.Location = new System.Drawing.Point(550, 332);
            CodeLb2.Size = new System.Drawing.Size(450, 38);
            CodeLb2.TabIndex = 55;
            CodeLb2.Text = BookList[index].Code.ToString();
            this.ScrolPanel.Controls.Add(CodeLb2);
    
            
            Label EboutLb2 = new Label();
            EboutLb2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EboutLb2.Location = new System.Drawing.Point(210, 400);
            EboutLb2.Size = new System.Drawing.Size(700, 100);
            EboutLb2.TabIndex = 56;
            EboutLb2.Text = BookList[index].Ebout;
            this.ScrolPanel.Controls.Add(EboutLb2);


            if (Imtihon29.Program.Checker)
            {

                var Rents = Imtihon29.Program.RentList;
                List<Rent> RentList = new List<Rent>();
                for (int i = 0; i < Rents.Count; i++)
                {
                    if (Rents[i].RentBook.Code.ToString() == button.Text)
                    {
                        RentList.Add(Rents[i]);
                    }
                }
                X = 68;
                Y = 550;
                DateTime nowdate = DateTime.Now;
                for (int i = 0; i < RentList.Count; i++)
                {

                    Panel panel = new Panel();
                    if (RentList[i].Submitted)
                    {
                        panel.BackColor = System.Drawing.Color.Green;
                    }
                    else if (RentList[i].ReturnDate < nowdate && RentList[i].Submitted == false)
                    {
                        panel.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        panel.BackColor = System.Drawing.Color.Yellow;
                    }
                    panel.Location = new System.Drawing.Point(X, Y);
                    panel.Size = new System.Drawing.Size(930, 160);

                    Panel BImagePnl = new Panel();
                    BImagePnl.Dock = System.Windows.Forms.DockStyle.Left;
                    BImagePnl.Location = new System.Drawing.Point(0, 0);
                    BImagePnl.Size = new System.Drawing.Size(140, 200);
                    Image image = Image.FromFile(RentList[i].RentBook.ImagePath);
                    var resizeimage = new Bitmap(img, 140, 200);
                    BImagePnl.BackgroundImage = resizeimage;
                    panel.Controls.Add(BImagePnl);

                    Label label1 = new Label();
                    label1.AutoSize = true;
                    label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label1.Location = new System.Drawing.Point(150, 90);
                    label1.ForeColor = System.Drawing.Color.Maroon;
                    label1.Size = new System.Drawing.Size(130, 26);
                    label1.Text = "Book code";
                    panel.Controls.Add(label1);

                    Label BCodeLb = new Label();
                    BCodeLb.AutoSize = true;
                    BCodeLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BCodeLb.Location = new System.Drawing.Point(150, 115);
                    BCodeLb.Size = new System.Drawing.Size(94, 32);
                    BCodeLb.Text = RentList[i].RentBook.Code.ToString();
                    panel.Controls.Add(BCodeLb);


                    Label label5 = new Label();
                    label5.AutoSize = true;
                    label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label5.Location = new System.Drawing.Point(150, 19);
                    label5.ForeColor = System.Drawing.Color.Maroon;
                    label5.Size = new System.Drawing.Size(126, 26);
                    label5.Text = "Book name";
                    panel.Controls.Add(label5);

                    Label BNameLb = new Label();
                    BNameLb.AutoSize = true;
                    BNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BNameLb.Location = new System.Drawing.Point(150, 45);
                    BNameLb.Size = new System.Drawing.Size(178, 32);
                    BNameLb.Text = RentList[i].RentBook.Name;
                    panel.Controls.Add(BNameLb);

                    Label label2 = new Label();
                    label2.AutoSize = true;
                    label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label2.Location = new System.Drawing.Point(630, 90);
                    label2.ForeColor = System.Drawing.Color.Maroon;
                    label2.Size = new System.Drawing.Size(130, 26);
                    label2.Text = "Return date";
                    panel.Controls.Add(label2);

                    Label ReturnLb = new Label();
                    ReturnLb.AutoSize = true;
                    ReturnLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ReturnLb.Location = new System.Drawing.Point(630, 115);
                    ReturnLb.Size = new System.Drawing.Size(158, 32);
                    ReturnLb.Text = RentList[i].ReturnDate.ToShortDateString();
                    panel.Controls.Add(ReturnLb);

                    Label label3 = new Label();
                    label3.AutoSize = true;
                    label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label3.Location = new System.Drawing.Point(465, 90);
                    label3.ForeColor = System.Drawing.Color.Maroon;
                    label3.Size = new System.Drawing.Size(130, 26);
                    label3.Text = "Delivery date";
                    panel.Controls.Add(label3);

                    Label RDelLb = new Label();
                    RDelLb.AutoSize = true;
                    RDelLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    RDelLb.Location = new System.Drawing.Point(465, 115);
                    RDelLb.Size = new System.Drawing.Size(158, 32);
                    RDelLb.Text = RentList[i].DeleveryDate.ToShortDateString();
                    panel.Controls.Add(RDelLb);

                    Label label4 = new Label();
                    label4.AutoSize = true;
                    label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label4.Location = new System.Drawing.Point(300, 90);
                    label4.ForeColor = System.Drawing.Color.Maroon;
                    label4.Size = new System.Drawing.Size(130, 26);
                    label4.Text = "Phone nuber";
                    panel.Controls.Add(label4);

                    Label RPnumLb = new Label();
                    RPnumLb.AutoSize = true;
                    RPnumLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    RPnumLb.Location = new System.Drawing.Point(300, 115);
                    RPnumLb.Size = new System.Drawing.Size(158, 32);
                    RPnumLb.Text = RentList[i].PhoneNumber;
                    panel.Controls.Add(RPnumLb);


                    Label label6 = new Label();
                    label6.AutoSize = true;
                    label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label6.Location = new System.Drawing.Point(730, 19);
                    label6.ForeColor = System.Drawing.Color.Maroon;
                    label6.Size = new System.Drawing.Size(126, 26);
                    label6.Text = "Passpotr seria number";
                    panel.Controls.Add(label6);

                    Label RPseriaLb = new Label();
                    RPseriaLb.AutoSize = true;
                    RPseriaLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    RPseriaLb.Location = new System.Drawing.Point(750, 45);
                    RPseriaLb.Size = new System.Drawing.Size(164, 32);
                    RPseriaLb.Text = RentList[i].PasportData;
                    panel.Controls.Add(RPseriaLb);

                    Label label7 = new Label();
                    label7.AutoSize = true;
                    label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label7.Location = new System.Drawing.Point(400, 19);
                    label7.ForeColor = System.Drawing.Color.Maroon;
                    label7.Size = new System.Drawing.Size(126, 26);
                    label7.Text = "Fullname";
                    panel.Controls.Add(label7);

                    Label RNameLb = new Label();
                    RNameLb.AutoSize = true;
                    RNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    RNameLb.Location = new System.Drawing.Point(400, 45);
                    RNameLb.Size = new System.Drawing.Size(400, 32);
                    RNameLb.Text = RentList[i].Fullname;
                    panel.Controls.Add(RNameLb);

                    Button DElbutton = new Button();
                    DElbutton.FlatAppearance.BorderSize = 0;
                    DElbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    DElbutton.Image = Image.FromFile("ExtraComponent/bin.png");
                    DElbutton.Location = new System.Drawing.Point(870, 95);
                    DElbutton.Size = new System.Drawing.Size(50, 50);
                    DElbutton.UseVisualStyleBackColor = true;
                    DElbutton.Click += new System.EventHandler(this.button_click);
                    panel.Controls.Add(DElbutton);
                    button.Name = i.ToString();

                    Button button2 = new Button();
                    button2.FlatAppearance.BorderSize = 0;
                    button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button2.Image = Image.FromFile("ExtraComponent/check3.png");
                    button2.Location = new System.Drawing.Point(820, 95);
                    button2.Size = new System.Drawing.Size(50, 50);
                    button2.UseVisualStyleBackColor = true;
                    button2.Click += new System.EventHandler(this.button2_click);
                    panel.Controls.Add(button2);
                    button2.Name = "b" + i.ToString();

                    this.ScrolPanel.Controls.Add(panel);

                    Y += 190;
                }
            }




        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MoveBooks();
        }

        private void BRentBtn_Click(object sender, EventArgs e)
        {
            int index = 0;
            var BookList = Imtihon29.Program.BookList;
            Button button = Btn2;
            Image image = button.Image;
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Code == int.Parse(button.Text))
                {
                    index = i;
                    break;
                }
            }
            RentForm form = new RentForm();
            form.AddImage(BookList[index], image);
            form.ShowDialog();
            MoveBooks();
        }

    }
}
