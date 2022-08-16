namespace HolyCrossParishDesktopApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBookedEvent = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookAnEvents = new Guna.UI2.WinForms.Guna2Button();
            this.btnCert = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddF = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSmartSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelChile = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(994, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 680);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 60);
            this.panel2.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 36);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(952, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 20.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(154, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(741, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Holy Cross Parish Profiling Management System";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBookedEvent);
            this.panel3.Controls.Add(this.btnBookAnEvents);
            this.panel3.Controls.Add(this.btnCert);
            this.panel3.Controls.Add(this.btnAddF);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.btnSmartSearch);
            this.panel3.Controls.Add(this.btnDashboard);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 620);
            this.panel3.TabIndex = 2;
            // 
            // btnBookedEvent
            // 
            this.btnBookedEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookedEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookedEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookedEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookedEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookedEvent.FillColor = System.Drawing.Color.Green;
            this.btnBookedEvent.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnBookedEvent.ForeColor = System.Drawing.Color.White;
            this.btnBookedEvent.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnBookedEvent.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnBookedEvent.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBookedEvent.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnBookedEvent.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnBookedEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnBookedEvent.Image")));
            this.btnBookedEvent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookedEvent.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnBookedEvent.Location = new System.Drawing.Point(0, 420);
            this.btnBookedEvent.Name = "btnBookedEvent";
            this.btnBookedEvent.Size = new System.Drawing.Size(197, 50);
            this.btnBookedEvent.TabIndex = 10;
            this.btnBookedEvent.Text = "Booked Event";
            this.btnBookedEvent.Click += new System.EventHandler(this.btnBookedEvent_Click);
            // 
            // btnBookAnEvents
            // 
            this.btnBookAnEvents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookAnEvents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookAnEvents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookAnEvents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookAnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookAnEvents.FillColor = System.Drawing.Color.Green;
            this.btnBookAnEvents.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnBookAnEvents.ForeColor = System.Drawing.Color.White;
            this.btnBookAnEvents.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnBookAnEvents.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnBookAnEvents.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBookAnEvents.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnBookAnEvents.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnBookAnEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnBookAnEvents.Image")));
            this.btnBookAnEvents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookAnEvents.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnBookAnEvents.Location = new System.Drawing.Point(0, 370);
            this.btnBookAnEvents.Name = "btnBookAnEvents";
            this.btnBookAnEvents.Size = new System.Drawing.Size(197, 50);
            this.btnBookAnEvents.TabIndex = 9;
            this.btnBookAnEvents.Text = "Confirm An Event";
            this.btnBookAnEvents.Click += new System.EventHandler(this.btnBookAnEvents_Click);
            // 
            // btnCert
            // 
            this.btnCert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCert.FillColor = System.Drawing.Color.Green;
            this.btnCert.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCert.ForeColor = System.Drawing.Color.White;
            this.btnCert.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnCert.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnCert.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCert.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnCert.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnCert.Image = ((System.Drawing.Image)(resources.GetObject("btnCert.Image")));
            this.btnCert.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCert.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCert.Location = new System.Drawing.Point(0, 320);
            this.btnCert.Name = "btnCert";
            this.btnCert.Size = new System.Drawing.Size(197, 50);
            this.btnCert.TabIndex = 7;
            this.btnCert.Text = "Sacramental Certificate";
            this.btnCert.Click += new System.EventHandler(this.btnCert_Click);
            // 
            // btnAddF
            // 
            this.btnAddF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddF.FillColor = System.Drawing.Color.Green;
            this.btnAddF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddF.ForeColor = System.Drawing.Color.White;
            this.btnAddF.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnAddF.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnAddF.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddF.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnAddF.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnAddF.Image = ((System.Drawing.Image)(resources.GetObject("btnAddF.Image")));
            this.btnAddF.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddF.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAddF.Location = new System.Drawing.Point(0, 270);
            this.btnAddF.Name = "btnAddF";
            this.btnAddF.Size = new System.Drawing.Size(197, 50);
            this.btnAddF.TabIndex = 6;
            this.btnAddF.Text = "Add a Faithful";
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Green;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnLogout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Location = new System.Drawing.Point(0, 570);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSmartSearch
            // 
            this.btnSmartSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSmartSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSmartSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSmartSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSmartSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmartSearch.FillColor = System.Drawing.Color.Green;
            this.btnSmartSearch.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSmartSearch.ForeColor = System.Drawing.Color.White;
            this.btnSmartSearch.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnSmartSearch.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnSmartSearch.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSmartSearch.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnSmartSearch.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnSmartSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSmartSearch.Image")));
            this.btnSmartSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSmartSearch.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSmartSearch.Location = new System.Drawing.Point(0, 220);
            this.btnSmartSearch.Name = "btnSmartSearch";
            this.btnSmartSearch.Size = new System.Drawing.Size(197, 50);
            this.btnSmartSearch.TabIndex = 2;
            this.btnSmartSearch.Text = "Faithful Members";
            this.btnSmartSearch.Click += new System.EventHandler(this.btnSmartSearch_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.Green;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.Green;
            this.btnDashboard.HoverState.CustomBorderColor = System.Drawing.Color.Green;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Green;
            this.btnDashboard.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.Location = new System.Drawing.Point(0, 170);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(197, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 170);
            this.panel4.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(37, 21);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(128, 130);
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panelChile
            // 
            this.panelChile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChile.Location = new System.Drawing.Point(197, 60);
            this.panelChile.Name = "panelChile";
            this.panelChile.Size = new System.Drawing.Size(797, 620);
            this.panelChile.TabIndex = 3;
            this.panelChile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChile_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.panelChile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnSmartSearch;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddF;
        private Guna.UI2.WinForms.Guna2Button btnCert;
        private System.Windows.Forms.Panel panelChile;
        private Guna.UI2.WinForms.Guna2Button btnBookAnEvents;
        private Guna.UI2.WinForms.Guna2Button btnBookedEvent;
    }
}