namespace Imtihon29.Forms
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NameLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuiSlidingPanel2 = new XanderUI.XUISlidingPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInBtn = new Guna.UI.WinForms.GunaButton();
            this.PaswordLb = new Guna.UI.WinForms.GunaLabel();
            this.PasswordTBox = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmailLb = new Guna.UI.WinForms.GunaLabel();
            this.EmailTBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.xuiSlidingPanel2.SuspendLayout();
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
            this.TopPanel.TabIndex = 1;
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
            this.MinimizeBtn.Location = new System.Drawing.Point(-2, 1);
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
            this.ExitBtn.Location = new System.Drawing.Point(58, -1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(64, 44);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLb.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.Color.White;
            this.NameLb.Location = new System.Drawing.Point(3, 3);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(78, 40);
            this.NameLb.TabIndex = 1;
            this.NameLb.Text = "IQRO";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.xuiSlidingPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 763);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(399, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 763);
            this.panel3.TabIndex = 3;
            // 
            // xuiSlidingPanel2
            // 
            this.xuiSlidingPanel2.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiSlidingPanel2.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiSlidingPanel2.CollapseControl = null;
            this.xuiSlidingPanel2.Collapsed = true;
            this.xuiSlidingPanel2.Controls.Add(this.label2);
            this.xuiSlidingPanel2.Controls.Add(this.label1);
            this.xuiSlidingPanel2.Controls.Add(this.SignInBtn);
            this.xuiSlidingPanel2.Controls.Add(this.PaswordLb);
            this.xuiSlidingPanel2.Controls.Add(this.PasswordTBox);
            this.xuiSlidingPanel2.Controls.Add(this.panel2);
            this.xuiSlidingPanel2.Controls.Add(this.EmailLb);
            this.xuiSlidingPanel2.Controls.Add(this.EmailTBox);
            this.xuiSlidingPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel2.HideControls = false;
            this.xuiSlidingPanel2.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel2.Name = "xuiSlidingPanel2";
            this.xuiSlidingPanel2.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel2.PanelWidthExpanded = 200;
            this.xuiSlidingPanel2.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel2.Size = new System.Drawing.Size(405, 763);
            this.xuiSlidingPanel2.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel2.TabIndex = 2;
            this.xuiSlidingPanel2.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiSlidingPanel2.TopRight = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "email  1 ";
            // 
            // SignInBtn
            // 
            this.SignInBtn.AnimationHoverSpeed = 0.07F;
            this.SignInBtn.AnimationSpeed = 0.03F;
            this.SignInBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignInBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SignInBtn.BorderColor = System.Drawing.Color.Black;
            this.SignInBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignInBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Image = null;
            this.SignInBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SignInBtn.Location = new System.Drawing.Point(72, 463);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SignInBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SignInBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SignInBtn.OnHoverImage = null;
            this.SignInBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SignInBtn.Radius = 20;
            this.SignInBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignInBtn.Size = new System.Drawing.Size(264, 54);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Sign in";
            this.SignInBtn.TextOffsetX = 60;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // PaswordLb
            // 
            this.PaswordLb.AutoSize = true;
            this.PaswordLb.BackColor = System.Drawing.Color.Transparent;
            this.PaswordLb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaswordLb.ForeColor = System.Drawing.Color.White;
            this.PaswordLb.Location = new System.Drawing.Point(38, 317);
            this.PaswordLb.Name = "PaswordLb";
            this.PaswordLb.Size = new System.Drawing.Size(98, 23);
            this.PaswordLb.TabIndex = 4;
            this.PaswordLb.Text = "Password";
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTBox.BaseColor = System.Drawing.Color.White;
            this.PasswordTBox.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordTBox.BorderSize = 3;
            this.PasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTBox.Location = new System.Drawing.Point(25, 343);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.PasswordChar = '\0';
            this.PasswordTBox.Radius = 20;
            this.PasswordTBox.SelectedText = "";
            this.PasswordTBox.Size = new System.Drawing.Size(353, 56);
            this.PasswordTBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 209);
            this.panel2.TabIndex = 2;
            // 
            // EmailLb
            // 
            this.EmailLb.AutoSize = true;
            this.EmailLb.BackColor = System.Drawing.Color.Transparent;
            this.EmailLb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLb.ForeColor = System.Drawing.Color.White;
            this.EmailLb.Location = new System.Drawing.Point(36, 219);
            this.EmailLb.Name = "EmailLb";
            this.EmailLb.Size = new System.Drawing.Size(58, 23);
            this.EmailLb.TabIndex = 1;
            this.EmailLb.Text = "Email";
            // 
            // EmailTBox
            // 
            this.EmailTBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailTBox.BaseColor = System.Drawing.Color.White;
            this.EmailTBox.BorderColor = System.Drawing.Color.Transparent;
            this.EmailTBox.BorderSize = 3;
            this.EmailTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTBox.FocusedBaseColor = System.Drawing.Color.White;
            this.EmailTBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTBox.Location = new System.Drawing.Point(25, 245);
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.PasswordChar = '\0';
            this.EmailTBox.Radius = 20;
            this.EmailTBox.SelectedText = "";
            this.EmailTBox.Size = new System.Drawing.Size(353, 56);
            this.EmailTBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "password  1 ";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.xuiSlidingPanel2.ResumeLayout(false);
            this.xuiSlidingPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISlidingPanel xuiSlidingPanel2;
        private Guna.UI.WinForms.GunaButton SignInBtn;
        private Guna.UI.WinForms.GunaLabel PaswordLb;
        private Guna.UI.WinForms.GunaTextBox PasswordTBox;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel EmailLb;
        private Guna.UI.WinForms.GunaTextBox EmailTBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}