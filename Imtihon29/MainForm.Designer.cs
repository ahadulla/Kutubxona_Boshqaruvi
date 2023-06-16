namespace Imtihon29
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NameLb = new System.Windows.Forms.Label();
            this.MePnTimer = new System.Windows.Forms.Timer(this.components);
            this.MePnTimer1 = new System.Windows.Forms.Timer(this.components);
            this.oyna = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTBox = new Guna.UI.WinForms.GunaTextBox();
            this.MenuPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuPanel1 = new System.Windows.Forms.Panel();
            this.MenuLb = new System.Windows.Forms.Label();
            this.POpenBtn = new System.Windows.Forms.Button();
            this.MenuPanel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.MenuPanel3 = new System.Windows.Forms.Panel();
            this.RentBtn = new System.Windows.Forms.Button();
            this.MenuPanel4 = new System.Windows.Forms.Panel();
            this.MenuPanel5 = new System.Windows.Forms.Panel();
            this.LgOBtn = new System.Windows.Forms.Button();
            this.ScrolPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.oyna.SuspendLayout();
            this.panel.SuspendLayout();
            this.MenuPnl.SuspendLayout();
            this.MenuPanel1.SuspendLayout();
            this.MenuPanel2.SuspendLayout();
            this.MenuPanel3.SuspendLayout();
            this.MenuPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.ControlPanel);
            this.TopPanel.Controls.Add(this.NameLb);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1364, 40);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.MinimizeBtn);
            this.ControlPanel.Controls.Add(this.ExitBtn);
            this.ControlPanel.Location = new System.Drawing.Point(1244, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(120, 40);
            this.ControlPanel.TabIndex = 1;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(4, 1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(60, 40);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(63, -1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(64, 44);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // NameLb
            // 
            this.NameLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLb.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(-2, -4);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(101, 48);
            this.NameLb.TabIndex = 1;
            this.NameLb.Text = "IQRO";
            this.NameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MePnTimer
            // 
            this.MePnTimer.Interval = 8;
            this.MePnTimer.Tick += new System.EventHandler(this.MePnTimer_Tick);
            // 
            // MePnTimer1
            // 
            this.MePnTimer1.Interval = 8;
            this.MePnTimer1.Tick += new System.EventHandler(this.MePnTimer1_Tick);
            // 
            // oyna
            // 
            this.oyna.BackColor = System.Drawing.Color.Silver;
            this.oyna.Controls.Add(this.MenuPnl);
            this.oyna.Controls.Add(this.panel);
            this.oyna.Controls.Add(this.ScrolPanel);
            this.oyna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyna.Location = new System.Drawing.Point(0, 40);
            this.oyna.Name = "oyna";
            this.oyna.Size = new System.Drawing.Size(1364, 763);
            this.oyna.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Gray;
            this.panel.Controls.Add(this.searchBtn);
            this.panel.Controls.Add(this.searchTBox);
            this.panel.Location = new System.Drawing.Point(52, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1312, 60);
            this.panel.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1242, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(35, 35);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTBox
            // 
            this.searchTBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchTBox.BaseColor = System.Drawing.Color.White;
            this.searchTBox.BorderColor = System.Drawing.Color.Silver;
            this.searchTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTBox.FocusedBaseColor = System.Drawing.Color.White;
            this.searchTBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchTBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.searchTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTBox.Location = new System.Drawing.Point(822, 7);
            this.searchTBox.Name = "searchTBox";
            this.searchTBox.PasswordChar = '\0';
            this.searchTBox.Radius = 20;
            this.searchTBox.SelectedText = "";
            this.searchTBox.Size = new System.Drawing.Size(469, 50);
            this.searchTBox.TabIndex = 0;
            // 
            // MenuPnl
            // 
            this.MenuPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPnl.Controls.Add(this.MenuPanel1);
            this.MenuPnl.Controls.Add(this.MenuPanel2);
            this.MenuPnl.Controls.Add(this.MenuPanel3);
            this.MenuPnl.Controls.Add(this.MenuPanel4);
            this.MenuPnl.Controls.Add(this.MenuPanel5);
            this.MenuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPnl.Location = new System.Drawing.Point(0, 0);
            this.MenuPnl.MaximumSize = new System.Drawing.Size(314, 763);
            this.MenuPnl.MinimumSize = new System.Drawing.Size(52, 763);
            this.MenuPnl.Name = "MenuPnl";
            this.MenuPnl.Size = new System.Drawing.Size(52, 763);
            this.MenuPnl.TabIndex = 1;
            // 
            // MenuPanel1
            // 
            this.MenuPanel1.Controls.Add(this.MenuLb);
            this.MenuPanel1.Controls.Add(this.POpenBtn);
            this.MenuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel1.Location = new System.Drawing.Point(3, 3);
            this.MenuPanel1.Name = "MenuPanel1";
            this.MenuPanel1.Size = new System.Drawing.Size(311, 60);
            this.MenuPanel1.TabIndex = 1;
            // 
            // MenuLb
            // 
            this.MenuLb.AutoSize = true;
            this.MenuLb.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLb.ForeColor = System.Drawing.Color.White;
            this.MenuLb.Location = new System.Drawing.Point(70, 6);
            this.MenuLb.Name = "MenuLb";
            this.MenuLb.Size = new System.Drawing.Size(104, 38);
            this.MenuLb.TabIndex = 2;
            this.MenuLb.Text = "Menu";
            // 
            // POpenBtn
            // 
            this.POpenBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.POpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.POpenBtn.FlatAppearance.BorderSize = 0;
            this.POpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("POpenBtn.Image")));
            this.POpenBtn.Location = new System.Drawing.Point(3, 3);
            this.POpenBtn.Name = "POpenBtn";
            this.POpenBtn.Size = new System.Drawing.Size(43, 43);
            this.POpenBtn.TabIndex = 0;
            this.POpenBtn.UseVisualStyleBackColor = false;
            this.POpenBtn.Click += new System.EventHandler(this.POpenBtn_Click);
            // 
            // MenuPanel2
            // 
            this.MenuPanel2.Controls.Add(this.HomeBtn);
            this.MenuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel2.Location = new System.Drawing.Point(3, 69);
            this.MenuPanel2.Name = "MenuPanel2";
            this.MenuPanel2.Size = new System.Drawing.Size(311, 60);
            this.MenuPanel2.TabIndex = 2;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(-3, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(314, 60);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "       Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MenuPanel3
            // 
            this.MenuPanel3.Controls.Add(this.RentBtn);
            this.MenuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel3.Location = new System.Drawing.Point(3, 135);
            this.MenuPanel3.Name = "MenuPanel3";
            this.MenuPanel3.Size = new System.Drawing.Size(311, 60);
            this.MenuPanel3.TabIndex = 3;
            // 
            // RentBtn
            // 
            this.RentBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RentBtn.FlatAppearance.BorderSize = 0;
            this.RentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentBtn.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentBtn.ForeColor = System.Drawing.Color.White;
            this.RentBtn.Image = ((System.Drawing.Image)(resources.GetObject("RentBtn.Image")));
            this.RentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RentBtn.Location = new System.Drawing.Point(-3, 0);
            this.RentBtn.Name = "RentBtn";
            this.RentBtn.Size = new System.Drawing.Size(314, 60);
            this.RentBtn.TabIndex = 0;
            this.RentBtn.Text = "       Rent";
            this.RentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RentBtn.UseVisualStyleBackColor = true;
            this.RentBtn.Click += new System.EventHandler(this.RentBtn_Click);
            // 
            // MenuPanel4
            // 
            this.MenuPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel4.Location = new System.Drawing.Point(3, 201);
            this.MenuPanel4.Name = "MenuPanel4";
            this.MenuPanel4.Size = new System.Drawing.Size(311, 397);
            this.MenuPanel4.TabIndex = 4;
            // 
            // MenuPanel5
            // 
            this.MenuPanel5.Controls.Add(this.LgOBtn);
            this.MenuPanel5.Location = new System.Drawing.Point(3, 604);
            this.MenuPanel5.Name = "MenuPanel5";
            this.MenuPanel5.Size = new System.Drawing.Size(311, 60);
            this.MenuPanel5.TabIndex = 5;
            // 
            // LgOBtn
            // 
            this.LgOBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LgOBtn.FlatAppearance.BorderSize = 0;
            this.LgOBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LgOBtn.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgOBtn.ForeColor = System.Drawing.Color.White;
            this.LgOBtn.Image = ((System.Drawing.Image)(resources.GetObject("LgOBtn.Image")));
            this.LgOBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LgOBtn.Location = new System.Drawing.Point(-3, 0);
            this.LgOBtn.Name = "LgOBtn";
            this.LgOBtn.Size = new System.Drawing.Size(314, 60);
            this.LgOBtn.TabIndex = 0;
            this.LgOBtn.Text = "Log out";
            this.LgOBtn.UseVisualStyleBackColor = true;
            this.LgOBtn.Click += new System.EventHandler(this.LgOBtn_Click);
            // 
            // ScrolPanel
            // 
            this.ScrolPanel.AutoScroll = true;
            this.ScrolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrolPanel.ForeColor = System.Drawing.Color.Black;
            this.ScrolPanel.Location = new System.Drawing.Point(0, 0);
            this.ScrolPanel.Name = "ScrolPanel";
            this.ScrolPanel.Size = new System.Drawing.Size(1364, 763);
            this.ScrolPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 803);
            this.Controls.Add(this.oyna);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.oyna.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.MenuPnl.ResumeLayout(false);
            this.MenuPanel1.ResumeLayout(false);
            this.MenuPanel1.PerformLayout();
            this.MenuPanel2.ResumeLayout(false);
            this.MenuPanel3.ResumeLayout(false);
            this.MenuPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Timer MePnTimer;
        private System.Windows.Forms.Timer MePnTimer1;
        private System.Windows.Forms.Panel oyna;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel MenuPnl;
        private System.Windows.Forms.Panel MenuPanel1;
        private System.Windows.Forms.Label MenuLb;
        private System.Windows.Forms.Button POpenBtn;
        private System.Windows.Forms.Panel MenuPanel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel MenuPanel3;
        private System.Windows.Forms.Button RentBtn;
        private System.Windows.Forms.Panel MenuPanel4;
        private System.Windows.Forms.Panel MenuPanel5;
        private System.Windows.Forms.Button LgOBtn;
        private Guna.UI.WinForms.GunaTextBox searchTBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel ScrolPanel;
        //private System.Windows.Forms.Button AddSectionBtn;
    }
}

