namespace HolyCrossParishDesktopApplication
{
    partial class GenerateCommunion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateCommunion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtMCommunion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbtCommunicant = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbtDirector = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbtPriestCommunion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbtYearCommunion = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbtParishCommunion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbtDayCommunion = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 42);
            this.panel1.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(735, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 29);
            this.btnClose.TabIndex = 46;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 16.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generating First Communion Certificate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Communicant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of the Communion";
            // 
            // cbtMCommunion
            // 
            this.cbtMCommunion.BackColor = System.Drawing.Color.Transparent;
            this.cbtMCommunion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtMCommunion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtMCommunion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtMCommunion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtMCommunion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbtMCommunion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbtMCommunion.ItemHeight = 30;
            this.cbtMCommunion.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May ",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbtMCommunion.Location = new System.Drawing.Point(323, 221);
            this.cbtMCommunion.Name = "cbtMCommunion";
            this.cbtMCommunion.Size = new System.Drawing.Size(182, 36);
            this.cbtMCommunion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(245, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Month:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(546, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year:";
            // 
            // tbtCommunicant
            // 
            this.tbtCommunicant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtCommunicant.DefaultText = "";
            this.tbtCommunicant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtCommunicant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtCommunicant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtCommunicant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtCommunicant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtCommunicant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtCommunicant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtCommunicant.Location = new System.Drawing.Point(177, 84);
            this.tbtCommunicant.Name = "tbtCommunicant";
            this.tbtCommunicant.PasswordChar = '\0';
            this.tbtCommunicant.PlaceholderText = "";
            this.tbtCommunicant.SelectedText = "";
            this.tbtCommunicant.Size = new System.Drawing.Size(569, 23);
            this.tbtCommunicant.TabIndex = 9;
            this.tbtCommunicant.TextChanged += new System.EventHandler(this.tbtCommunicant_TextChanged);
            // 
            // tbtDirector
            // 
            this.tbtDirector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtDirector.DefaultText = "";
            this.tbtDirector.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtDirector.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtDirector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtDirector.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtDirector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtDirector.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtDirector.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtDirector.Location = new System.Drawing.Point(177, 366);
            this.tbtDirector.Name = "tbtDirector";
            this.tbtDirector.PasswordChar = '\0';
            this.tbtDirector.PlaceholderText = "";
            this.tbtDirector.SelectedText = "";
            this.tbtDirector.Size = new System.Drawing.Size(569, 23);
            this.tbtDirector.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Director:";
            // 
            // tbtPriestCommunion
            // 
            this.tbtPriestCommunion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtPriestCommunion.DefaultText = "";
            this.tbtPriestCommunion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtPriestCommunion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtPriestCommunion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtPriestCommunion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtPriestCommunion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtPriestCommunion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtPriestCommunion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtPriestCommunion.Location = new System.Drawing.Point(177, 434);
            this.tbtPriestCommunion.Name = "tbtPriestCommunion";
            this.tbtPriestCommunion.PasswordChar = '\0';
            this.tbtPriestCommunion.PlaceholderText = "";
            this.tbtPriestCommunion.SelectedText = "";
            this.tbtPriestCommunion.Size = new System.Drawing.Size(569, 23);
            this.tbtPriestCommunion.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(24, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Parish Priest:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(501, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate Certificate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(236, 491);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbtYearCommunion
            // 
            this.tbtYearCommunion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtYearCommunion.DefaultText = "";
            this.tbtYearCommunion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtYearCommunion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtYearCommunion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtYearCommunion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtYearCommunion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtYearCommunion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtYearCommunion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtYearCommunion.Location = new System.Drawing.Point(610, 221);
            this.tbtYearCommunion.Name = "tbtYearCommunion";
            this.tbtYearCommunion.PasswordChar = '\0';
            this.tbtYearCommunion.PlaceholderText = "";
            this.tbtYearCommunion.SelectedText = "";
            this.tbtYearCommunion.Size = new System.Drawing.Size(136, 36);
            this.tbtYearCommunion.TabIndex = 16;
            // 
            // tbtParishCommunion
            // 
            this.tbtParishCommunion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtParishCommunion.DefaultText = "";
            this.tbtParishCommunion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtParishCommunion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtParishCommunion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtParishCommunion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtParishCommunion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtParishCommunion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtParishCommunion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtParishCommunion.Location = new System.Drawing.Point(177, 304);
            this.tbtParishCommunion.Name = "tbtParishCommunion";
            this.tbtParishCommunion.PasswordChar = '\0';
            this.tbtParishCommunion.PlaceholderText = "";
            this.tbtParishCommunion.SelectedText = "";
            this.tbtParishCommunion.Size = new System.Drawing.Size(569, 23);
            this.tbtParishCommunion.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(24, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Parish:";
            // 
            // cbtDayCommunion
            // 
            this.cbtDayCommunion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbtDayCommunion.DefaultText = "";
            this.cbtDayCommunion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbtDayCommunion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbtDayCommunion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbtDayCommunion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbtDayCommunion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtDayCommunion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtDayCommunion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtDayCommunion.Location = new System.Drawing.Point(96, 221);
            this.cbtDayCommunion.Name = "cbtDayCommunion";
            this.cbtDayCommunion.PasswordChar = '\0';
            this.cbtDayCommunion.PlaceholderText = "Ordinal No.";
            this.cbtDayCommunion.SelectedText = "";
            this.cbtDayCommunion.Size = new System.Drawing.Size(116, 36);
            this.cbtDayCommunion.TabIndex = 19;
            this.cbtDayCommunion.TextChanged += new System.EventHandler(this.cbtDayCommunion_TextChanged);
            // 
            // GenerateCommunion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 571);
            this.Controls.Add(this.cbtDayCommunion);
            this.Controls.Add(this.tbtParishCommunion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbtYearCommunion);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbtPriestCommunion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbtDirector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbtCommunicant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbtMCommunion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateCommunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateCommunion";
            this.Load += new System.EventHandler(this.GenerateCommunion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbtMCommunion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbtCommunicant;
        private Guna.UI2.WinForms.Guna2TextBox tbtDirector;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbtPriestCommunion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox tbtYearCommunion;
        private Guna.UI2.WinForms.Guna2TextBox tbtParishCommunion;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox cbtDayCommunion;
    }
}