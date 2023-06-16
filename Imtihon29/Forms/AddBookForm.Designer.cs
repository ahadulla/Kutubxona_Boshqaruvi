namespace Imtihon29.Forms
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NameLb = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BNaameLb = new System.Windows.Forms.Label();
            this.AuthorLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.PageCLb = new System.Windows.Forms.Label();
            this.CountLb = new System.Windows.Forms.Label();
            this.ImageLb = new System.Windows.Forms.Label();
            this.EboutLb = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.AuthorTBox = new System.Windows.Forms.TextBox();
            this.PriceTBox = new System.Windows.Forms.TextBox();
            this.PageTBox = new System.Windows.Forms.TextBox();
            this.CountTBox = new System.Windows.Forms.TextBox();
            this.ImportImagBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CenselBtn = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.NameLb);
            this.TopPanel.Controls.Add(this.ControlPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(735, 40);
            this.TopPanel.TabIndex = 1;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(3, 6);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(135, 31);
            this.NameLb.TabIndex = 1;
            this.NameLb.Text = "Add book";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.HelpBtn);
            this.ControlPanel.Controls.Add(this.ExitBtn);
            this.ControlPanel.Location = new System.Drawing.Point(600, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(123, 40);
            this.ControlPanel.TabIndex = 1;
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.Location = new System.Drawing.Point(11, -3);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(52, 40);
            this.HelpBtn.TabIndex = 3;
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(64, -4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(64, 44);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BNaameLb
            // 
            this.BNaameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNaameLb.Location = new System.Drawing.Point(38, 69);
            this.BNaameLb.Name = "BNaameLb";
            this.BNaameLb.Size = new System.Drawing.Size(182, 38);
            this.BNaameLb.TabIndex = 2;
            this.BNaameLb.Text = "Name";
            // 
            // AuthorLb
            // 
            this.AuthorLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLb.Location = new System.Drawing.Point(38, 119);
            this.AuthorLb.Name = "AuthorLb";
            this.AuthorLb.Size = new System.Drawing.Size(182, 38);
            this.AuthorLb.TabIndex = 3;
            this.AuthorLb.Text = "Author";
            // 
            // PriceLb
            // 
            this.PriceLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLb.Location = new System.Drawing.Point(38, 172);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(182, 38);
            this.PriceLb.TabIndex = 4;
            this.PriceLb.Text = "Price";
            // 
            // PageCLb
            // 
            this.PageCLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageCLb.Location = new System.Drawing.Point(38, 228);
            this.PageCLb.Name = "PageCLb";
            this.PageCLb.Size = new System.Drawing.Size(182, 38);
            this.PageCLb.TabIndex = 5;
            this.PageCLb.Text = "Page Count";
            // 
            // CountLb
            // 
            this.CountLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLb.Location = new System.Drawing.Point(38, 282);
            this.CountLb.Name = "CountLb";
            this.CountLb.Size = new System.Drawing.Size(182, 38);
            this.CountLb.TabIndex = 6;
            this.CountLb.Text = "Book Code";
            // 
            // ImageLb
            // 
            this.ImageLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLb.Location = new System.Drawing.Point(38, 333);
            this.ImageLb.Name = "ImageLb";
            this.ImageLb.Size = new System.Drawing.Size(182, 38);
            this.ImageLb.TabIndex = 7;
            this.ImageLb.Text = "Image";
            // 
            // EboutLb
            // 
            this.EboutLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EboutLb.Location = new System.Drawing.Point(38, 388);
            this.EboutLb.Name = "EboutLb";
            this.EboutLb.Size = new System.Drawing.Size(182, 38);
            this.EboutLb.TabIndex = 8;
            this.EboutLb.Text = "Ebout";
            // 
            // NameTBox
            // 
            this.NameTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTBox.Location = new System.Drawing.Point(265, 69);
            this.NameTBox.Multiline = true;
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(398, 38);
            this.NameTBox.TabIndex = 9;
            // 
            // AuthorTBox
            // 
            this.AuthorTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTBox.Location = new System.Drawing.Point(265, 120);
            this.AuthorTBox.Multiline = true;
            this.AuthorTBox.Name = "AuthorTBox";
            this.AuthorTBox.Size = new System.Drawing.Size(398, 38);
            this.AuthorTBox.TabIndex = 10;
            // 
            // PriceTBox
            // 
            this.PriceTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTBox.Location = new System.Drawing.Point(265, 173);
            this.PriceTBox.Multiline = true;
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.Size = new System.Drawing.Size(398, 38);
            this.PriceTBox.TabIndex = 11;
            this.PriceTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTBox_KeyPress);
            // 
            // PageTBox
            // 
            this.PageTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTBox.Location = new System.Drawing.Point(265, 227);
            this.PageTBox.Multiline = true;
            this.PageTBox.Name = "PageTBox";
            this.PageTBox.Size = new System.Drawing.Size(398, 38);
            this.PageTBox.TabIndex = 12;
            this.PageTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PageTBox_KeyPress);
            // 
            // CountTBox
            // 
            this.CountTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTBox.Location = new System.Drawing.Point(265, 282);
            this.CountTBox.Multiline = true;
            this.CountTBox.Name = "CountTBox";
            this.CountTBox.Size = new System.Drawing.Size(398, 38);
            this.CountTBox.TabIndex = 13;
            this.CountTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountTBox_KeyPress);
            // 
            // ImportImagBtn
            // 
            this.ImportImagBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportImagBtn.Location = new System.Drawing.Point(265, 337);
            this.ImportImagBtn.Name = "ImportImagBtn";
            this.ImportImagBtn.Size = new System.Drawing.Size(398, 38);
            this.ImportImagBtn.TabIndex = 14;
            this.ImportImagBtn.Text = "Import";
            this.ImportImagBtn.UseVisualStyleBackColor = true;
            this.ImportImagBtn.Click += new System.EventHandler(this.ImportImagBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(407, 527);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(110, 36);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(265, 393);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 119);
            this.textBox1.TabIndex = 18;
            // 
            // CenselBtn
            // 
            this.CenselBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenselBtn.Location = new System.Drawing.Point(553, 527);
            this.CenselBtn.Name = "CenselBtn";
            this.CenselBtn.Size = new System.Drawing.Size(110, 36);
            this.CenselBtn.TabIndex = 16;
            this.CenselBtn.Text = "Cencel";
            this.CenselBtn.UseVisualStyleBackColor = true;
            this.CenselBtn.Click += new System.EventHandler(this.CenselBtn_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 587);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CenselBtn);
            this.Controls.Add(this.ImportImagBtn);
            this.Controls.Add(this.CountTBox);
            this.Controls.Add(this.PageTBox);
            this.Controls.Add(this.PriceTBox);
            this.Controls.Add(this.AuthorTBox);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.EboutLb);
            this.Controls.Add(this.ImageLb);
            this.Controls.Add(this.CountLb);
            this.Controls.Add(this.PageCLb);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.AuthorLb);
            this.Controls.Add(this.BNaameLb);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbbBookForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Label BNaameLb;
        private System.Windows.Forms.Label AuthorLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.Label PageCLb;
        private System.Windows.Forms.Label CountLb;
        private System.Windows.Forms.Label ImageLb;
        private System.Windows.Forms.Label EboutLb;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.TextBox AuthorTBox;
        private System.Windows.Forms.TextBox PriceTBox;
        private System.Windows.Forms.TextBox PageTBox;
        private System.Windows.Forms.TextBox CountTBox;
        private System.Windows.Forms.Button ImportImagBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CenselBtn;
    }
}