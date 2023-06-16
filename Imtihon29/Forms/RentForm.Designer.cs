namespace Imtihon29.Forms
{
    partial class RentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentForm));
            this.RentTopPnl = new System.Windows.Forms.Panel();
            this.RentNamePnl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RentHelpBtn = new System.Windows.Forms.Button();
            this.PentExit = new System.Windows.Forms.Button();
            this.ReturnTBox = new System.Windows.Forms.TextBox();
            this.ReturnLb = new System.Windows.Forms.Label();
            this.DeliveryTBox = new System.Windows.Forms.TextBox();
            this.DelivwryLb = new System.Windows.Forms.Label();
            this.PassportTBox = new System.Windows.Forms.TextBox();
            this.PasspLb = new System.Windows.Forms.Label();
            this.PnumTBox = new System.Windows.Forms.TextBox();
            this.PnumLb = new System.Windows.Forms.Label();
            this.FullnameTBox = new System.Windows.Forms.TextBox();
            this.FullNameLb = new System.Windows.Forms.Label();
            this.ImagePnl = new System.Windows.Forms.Panel();
            this.EboutTBox = new System.Windows.Forms.TextBox();
            this.EboutLb = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.RentTopPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentTopPnl
            // 
            this.RentTopPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RentTopPnl.Controls.Add(this.RentNamePnl);
            this.RentTopPnl.Controls.Add(this.panel3);
            this.RentTopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.RentTopPnl.Location = new System.Drawing.Point(0, 0);
            this.RentTopPnl.Name = "RentTopPnl";
            this.RentTopPnl.Size = new System.Drawing.Size(949, 40);
            this.RentTopPnl.TabIndex = 2;
            // 
            // RentNamePnl
            // 
            this.RentNamePnl.AutoSize = true;
            this.RentNamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RentNamePnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentNamePnl.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentNamePnl.ForeColor = System.Drawing.Color.White;
            this.RentNamePnl.Location = new System.Drawing.Point(3, 3);
            this.RentNamePnl.Name = "RentNamePnl";
            this.RentNamePnl.Size = new System.Drawing.Size(78, 40);
            this.RentNamePnl.TabIndex = 1;
            this.RentNamePnl.Text = "IQRO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RentHelpBtn);
            this.panel3.Controls.Add(this.PentExit);
            this.panel3.Location = new System.Drawing.Point(825, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 40);
            this.panel3.TabIndex = 1;
            // 
            // RentHelpBtn
            // 
            this.RentHelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RentHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentHelpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RentHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("RentHelpBtn.Image")));
            this.RentHelpBtn.Location = new System.Drawing.Point(17, 0);
            this.RentHelpBtn.Name = "RentHelpBtn";
            this.RentHelpBtn.Size = new System.Drawing.Size(52, 40);
            this.RentHelpBtn.TabIndex = 4;
            this.RentHelpBtn.UseVisualStyleBackColor = false;
            // 
            // PentExit
            // 
            this.PentExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PentExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PentExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PentExit.Image = ((System.Drawing.Image)(resources.GetObject("PentExit.Image")));
            this.PentExit.Location = new System.Drawing.Point(63, -1);
            this.PentExit.Name = "PentExit";
            this.PentExit.Size = new System.Drawing.Size(64, 44);
            this.PentExit.TabIndex = 1;
            this.PentExit.UseVisualStyleBackColor = false;
            this.PentExit.Click += new System.EventHandler(this.PentExit_Click);
            // 
            // ReturnTBox
            // 
            this.ReturnTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnTBox.Location = new System.Drawing.Point(585, 303);
            this.ReturnTBox.MaxLength = 10;
            this.ReturnTBox.Multiline = true;
            this.ReturnTBox.Name = "ReturnTBox";
            this.ReturnTBox.Size = new System.Drawing.Size(320, 46);
            this.ReturnTBox.TabIndex = 23;
            this.ReturnTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReturnTBox_KeyPress);
            // 
            // ReturnLb
            // 
            this.ReturnLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLb.Location = new System.Drawing.Point(582, 267);
            this.ReturnLb.Name = "ReturnLb";
            this.ReturnLb.Size = new System.Drawing.Size(171, 33);
            this.ReturnLb.TabIndex = 22;
            this.ReturnLb.Text = "Return date";
            // 
            // DeliveryTBox
            // 
            this.DeliveryTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryTBox.Location = new System.Drawing.Point(259, 303);
            this.DeliveryTBox.MaxLength = 10;
            this.DeliveryTBox.Multiline = true;
            this.DeliveryTBox.Name = "DeliveryTBox";
            this.DeliveryTBox.Size = new System.Drawing.Size(320, 46);
            this.DeliveryTBox.TabIndex = 21;
            this.DeliveryTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeliveryTBox_KeyPress);
            // 
            // DelivwryLb
            // 
            this.DelivwryLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelivwryLb.Location = new System.Drawing.Point(254, 267);
            this.DelivwryLb.Name = "DelivwryLb";
            this.DelivwryLb.Size = new System.Drawing.Size(181, 33);
            this.DelivwryLb.TabIndex = 20;
            this.DelivwryLb.Text = "Delivery date";
            // 
            // PassportTBox
            // 
            this.PassportTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassportTBox.Location = new System.Drawing.Point(259, 206);
            this.PassportTBox.MaxLength = 9;
            this.PassportTBox.Multiline = true;
            this.PassportTBox.Name = "PassportTBox";
            this.PassportTBox.Size = new System.Drawing.Size(320, 46);
            this.PassportTBox.TabIndex = 19;
            // 
            // PasspLb
            // 
            this.PasspLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasspLb.Location = new System.Drawing.Point(252, 170);
            this.PasspLb.Name = "PasspLb";
            this.PasspLb.Size = new System.Drawing.Size(299, 33);
            this.PasspLb.TabIndex = 18;
            this.PasspLb.Text = "Pasport serial number";
            // 
            // PnumTBox
            // 
            this.PnumTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnumTBox.Location = new System.Drawing.Point(585, 206);
            this.PnumTBox.MaxLength = 9;
            this.PnumTBox.Multiline = true;
            this.PnumTBox.Name = "PnumTBox";
            this.PnumTBox.Size = new System.Drawing.Size(320, 46);
            this.PnumTBox.TabIndex = 17;
            this.PnumTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PnumTBox_KeyPress);
            // 
            // PnumLb
            // 
            this.PnumLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnumLb.Location = new System.Drawing.Point(584, 170);
            this.PnumLb.Name = "PnumLb";
            this.PnumLb.Size = new System.Drawing.Size(211, 33);
            this.PnumLb.TabIndex = 16;
            this.PnumLb.Text = "Phone Number";
            // 
            // FullnameTBox
            // 
            this.FullnameTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameTBox.Location = new System.Drawing.Point(259, 110);
            this.FullnameTBox.Multiline = true;
            this.FullnameTBox.Name = "FullnameTBox";
            this.FullnameTBox.Size = new System.Drawing.Size(647, 46);
            this.FullnameTBox.TabIndex = 15;
            // 
            // FullNameLb
            // 
            this.FullNameLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLb.Location = new System.Drawing.Point(253, 74);
            this.FullNameLb.Name = "FullNameLb";
            this.FullNameLb.Size = new System.Drawing.Size(147, 33);
            this.FullNameLb.TabIndex = 14;
            this.FullNameLb.Text = "Fullname";
            // 
            // ImagePnl
            // 
            this.ImagePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePnl.Location = new System.Drawing.Point(43, 88);
            this.ImagePnl.Name = "ImagePnl";
            this.ImagePnl.Size = new System.Drawing.Size(160, 240);
            this.ImagePnl.TabIndex = 13;
            // 
            // EboutTBox
            // 
            this.EboutTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EboutTBox.Location = new System.Drawing.Point(48, 410);
            this.EboutTBox.Multiline = true;
            this.EboutTBox.Name = "EboutTBox";
            this.EboutTBox.Size = new System.Drawing.Size(858, 156);
            this.EboutTBox.TabIndex = 25;
            // 
            // EboutLb
            // 
            this.EboutLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EboutLb.Location = new System.Drawing.Point(42, 374);
            this.EboutLb.Name = "EboutLb";
            this.EboutLb.Size = new System.Drawing.Size(293, 33);
            this.EboutLb.TabIndex = 24;
            this.EboutLb.Text = "Additional information";
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(665, 590);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(106, 43);
            this.OkBtn.TabIndex = 27;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(800, 590);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(106, 43);
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.Text = "Cencel";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(949, 657);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.EboutTBox);
            this.Controls.Add(this.EboutLb);
            this.Controls.Add(this.ReturnTBox);
            this.Controls.Add(this.ReturnLb);
            this.Controls.Add(this.DeliveryTBox);
            this.Controls.Add(this.DelivwryLb);
            this.Controls.Add(this.PassportTBox);
            this.Controls.Add(this.PasspLb);
            this.Controls.Add(this.PnumTBox);
            this.Controls.Add(this.PnumLb);
            this.Controls.Add(this.FullnameTBox);
            this.Controls.Add(this.FullNameLb);
            this.Controls.Add(this.ImagePnl);
            this.Controls.Add(this.RentTopPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentForm";
            this.RentTopPnl.ResumeLayout(false);
            this.RentTopPnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RentTopPnl;
        private System.Windows.Forms.Label RentNamePnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RentHelpBtn;
        private System.Windows.Forms.Button PentExit;
        private System.Windows.Forms.TextBox ReturnTBox;
        private System.Windows.Forms.Label ReturnLb;
        private System.Windows.Forms.TextBox DeliveryTBox;
        private System.Windows.Forms.Label DelivwryLb;
        private System.Windows.Forms.TextBox PassportTBox;
        private System.Windows.Forms.Label PasspLb;
        private System.Windows.Forms.TextBox PnumTBox;
        private System.Windows.Forms.Label PnumLb;
        private System.Windows.Forms.TextBox FullnameTBox;
        private System.Windows.Forms.Label FullNameLb;
        private System.Windows.Forms.Panel ImagePnl;
        private System.Windows.Forms.TextBox EboutTBox;
        private System.Windows.Forms.Label EboutLb;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}