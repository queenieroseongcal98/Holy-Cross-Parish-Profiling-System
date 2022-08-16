namespace HolyCrossParishDesktopApplication
{
    partial class GenerateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateInvoice));
            this.genereateInvoicePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtCandidate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbtFather = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtMother = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSponsor2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSponsor1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMB1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDB1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGEnerateCert = new System.Windows.Forms.Button();
            this.cbYB = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbYB1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateboxPresentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.genereateInvoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // genereateInvoicePanel
            // 
            this.genereateInvoicePanel.BackColor = System.Drawing.Color.ForestGreen;
            this.genereateInvoicePanel.Controls.Add(this.btnClose);
            this.genereateInvoicePanel.Controls.Add(this.label1);
            this.genereateInvoicePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.genereateInvoicePanel.Location = new System.Drawing.Point(0, 0);
            this.genereateInvoicePanel.Name = "genereateInvoicePanel";
            this.genereateInvoicePanel.Size = new System.Drawing.Size(773, 41);
            this.genereateInvoicePanel.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(744, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 29);
            this.btnClose.TabIndex = 45;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENERATING BAPTISMAL CERTIFICATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baptismal Candidate:";
            // 
            // tbtCandidate
            // 
            this.tbtCandidate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtCandidate.DefaultText = "";
            this.tbtCandidate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtCandidate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtCandidate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtCandidate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtCandidate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtCandidate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtCandidate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtCandidate.Location = new System.Drawing.Point(241, 74);
            this.tbtCandidate.Name = "tbtCandidate";
            this.tbtCandidate.PasswordChar = '\0';
            this.tbtCandidate.PlaceholderText = "";
            this.tbtCandidate.SelectedText = "";
            this.tbtCandidate.Size = new System.Drawing.Size(496, 22);
            this.tbtCandidate.TabIndex = 2;
            this.tbtCandidate.TextChanged += new System.EventHandler(this.tbtCandidate_TextChanged);
            // 
            // tbtFather
            // 
            this.tbtFather.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtFather.DefaultText = "";
            this.tbtFather.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtFather.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtFather.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtFather.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtFather.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtFather.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtFather.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtFather.Location = new System.Drawing.Point(241, 118);
            this.tbtFather.Name = "tbtFather";
            this.tbtFather.PasswordChar = '\0';
            this.tbtFather.PlaceholderText = "";
            this.tbtFather.SelectedText = "";
            this.tbtFather.Size = new System.Drawing.Size(496, 22);
            this.tbtFather.TabIndex = 4;
            this.tbtFather.TextChanged += new System.EventHandler(this.tbtFather_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Father of the Candidate";
            // 
            // tbtMother
            // 
            this.tbtMother.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbtMother.DefaultText = "";
            this.tbtMother.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbtMother.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbtMother.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtMother.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbtMother.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtMother.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbtMother.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbtMother.Location = new System.Drawing.Point(241, 161);
            this.tbtMother.Name = "tbtMother";
            this.tbtMother.PasswordChar = '\0';
            this.tbtMother.PlaceholderText = "";
            this.tbtMother.SelectedText = "";
            this.tbtMother.Size = new System.Drawing.Size(496, 22);
            this.tbtMother.TabIndex = 6;
            this.tbtMother.TextChanged += new System.EventHandler(this.tbtMother_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mother of the Candidate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Present Date:";
            // 
            // tbSponsor2
            // 
            this.tbSponsor2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSponsor2.DefaultText = "";
            this.tbSponsor2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSponsor2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSponsor2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSponsor2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSponsor2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSponsor2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSponsor2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSponsor2.Location = new System.Drawing.Point(213, 509);
            this.tbSponsor2.Name = "tbSponsor2";
            this.tbSponsor2.PasswordChar = '\0';
            this.tbSponsor2.PlaceholderText = "";
            this.tbSponsor2.SelectedText = "";
            this.tbSponsor2.Size = new System.Drawing.Size(524, 22);
            this.tbSponsor2.TabIndex = 14;
            this.tbSponsor2.TextChanged += new System.EventHandler(this.tbSponsor2_TextChanged);
            // 
            // tbSponsor1
            // 
            this.tbSponsor1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSponsor1.DefaultText = "";
            this.tbSponsor1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSponsor1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSponsor1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSponsor1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSponsor1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSponsor1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSponsor1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSponsor1.Location = new System.Drawing.Point(213, 466);
            this.tbSponsor1.Name = "tbSponsor1";
            this.tbSponsor1.PasswordChar = '\0';
            this.tbSponsor1.PlaceholderText = "";
            this.tbSponsor1.SelectedText = "";
            this.tbSponsor1.Size = new System.Drawing.Size(524, 22);
            this.tbSponsor1.TabIndex = 12;
            this.tbSponsor1.TextChanged += new System.EventHandler(this.tbSponsor1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sponsors:";
            // 
            // tbOP
            // 
            this.tbOP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOP.DefaultText = "";
            this.tbOP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbOP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOP.Location = new System.Drawing.Point(213, 422);
            this.tbOP.Name = "tbOP";
            this.tbOP.PasswordChar = '\0';
            this.tbOP.PlaceholderText = "";
            this.tbOP.SelectedText = "";
            this.tbOP.Size = new System.Drawing.Size(524, 22);
            this.tbOP.TabIndex = 10;
            this.tbOP.TextChanged += new System.EventHandler(this.tbOP_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(23, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Officiating Priest:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(23, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Year of Birth:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(23, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Month of Birth:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(23, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "Day of Birth:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(388, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "Year of Baptismal:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(388, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 19);
            this.label16.TabIndex = 27;
            this.label16.Text = "Month of Baptismal:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(388, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "Day of Baptismal:";
            // 
            // cbMB
            // 
            this.cbMB.BackColor = System.Drawing.Color.Transparent;
            this.cbMB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMB.ItemHeight = 30;
            this.cbMB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMB.Location = new System.Drawing.Point(213, 306);
            this.cbMB.Name = "cbMB";
            this.cbMB.Size = new System.Drawing.Size(157, 36);
            this.cbMB.TabIndex = 33;
            this.cbMB.SelectedIndexChanged += new System.EventHandler(this.cbMB_SelectedIndexChanged);
            // 
            // cbMB1
            // 
            this.cbMB1.BackColor = System.Drawing.Color.Transparent;
            this.cbMB1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMB1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMB1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMB1.ItemHeight = 30;
            this.cbMB1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMB1.Location = new System.Drawing.Point(578, 306);
            this.cbMB1.Name = "cbMB1";
            this.cbMB1.Size = new System.Drawing.Size(157, 36);
            this.cbMB1.TabIndex = 37;
            this.cbMB1.SelectedIndexChanged += new System.EventHandler(this.cbMB1_SelectedIndexChanged);
            // 
            // cbDB1
            // 
            this.cbDB1.BackColor = System.Drawing.Color.Transparent;
            this.cbDB1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDB1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDB1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDB1.ItemHeight = 30;
            this.cbDB1.Items.AddRange(new object[] {
            "1st ",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th",
            "9th",
            "10th ",
            "11th",
            "12th",
            "13th",
            "14th",
            "15th",
            "16th",
            "17th",
            "18th",
            "19th",
            "20th ",
            "21st",
            "22nd",
            "23rd",
            "24th",
            "25th",
            "26th",
            "27th",
            "28th",
            "29th",
            "30th",
            "31st"});
            this.cbDB1.Location = new System.Drawing.Point(578, 248);
            this.cbDB1.Name = "cbDB1";
            this.cbDB1.Size = new System.Drawing.Size(157, 36);
            this.cbDB1.TabIndex = 36;
            this.cbDB1.SelectedIndexChanged += new System.EventHandler(this.cbDB1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "date of birth:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(388, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "date of baptismal:";
            // 
            // tbPP
            // 
            this.tbPP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPP.DefaultText = "";
            this.tbPP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPP.Location = new System.Drawing.Point(213, 612);
            this.tbPP.Name = "tbPP";
            this.tbPP.PasswordChar = '\0';
            this.tbPP.PlaceholderText = "";
            this.tbPP.SelectedText = "";
            this.tbPP.Size = new System.Drawing.Size(524, 22);
            this.tbPP.TabIndex = 41;
            this.tbPP.TextChanged += new System.EventHandler(this.tbPP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Parish Priest:";
            // 
            // btnGEnerateCert
            // 
            this.btnGEnerateCert.BackColor = System.Drawing.Color.Green;
            this.btnGEnerateCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGEnerateCert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGEnerateCert.ForeColor = System.Drawing.Color.White;
            this.btnGEnerateCert.Location = new System.Drawing.Point(551, 658);
            this.btnGEnerateCert.Name = "btnGEnerateCert";
            this.btnGEnerateCert.Size = new System.Drawing.Size(186, 31);
            this.btnGEnerateCert.TabIndex = 0;
            this.btnGEnerateCert.Text = "Generate Certificate";
            this.btnGEnerateCert.UseVisualStyleBackColor = false;
            this.btnGEnerateCert.Click += new System.EventHandler(this.btnGEnerateCert_Click);
            // 
            // cbYB
            // 
            this.cbYB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbYB.DefaultText = "";
            this.cbYB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbYB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbYB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbYB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbYB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbYB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYB.Location = new System.Drawing.Point(213, 360);
            this.cbYB.Name = "cbYB";
            this.cbYB.PasswordChar = '\0';
            this.cbYB.PlaceholderText = "";
            this.cbYB.SelectedText = "";
            this.cbYB.Size = new System.Drawing.Size(157, 34);
            this.cbYB.TabIndex = 42;
            this.cbYB.TextChanged += new System.EventHandler(this.cbYB_TextChanged);
            // 
            // cbYB1
            // 
            this.cbYB1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbYB1.DefaultText = "";
            this.cbYB1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbYB1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbYB1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbYB1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbYB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYB1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbYB1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYB1.Location = new System.Drawing.Point(578, 360);
            this.cbYB1.Name = "cbYB1";
            this.cbYB1.PasswordChar = '\0';
            this.cbYB1.PlaceholderText = "";
            this.cbYB1.SelectedText = "";
            this.cbYB1.Size = new System.Drawing.Size(157, 34);
            this.cbYB1.TabIndex = 43;
            this.cbYB1.TextChanged += new System.EventHandler(this.cbYB1_TextChanged);
            // 
            // dateboxPresentDate
            // 
            this.dateboxPresentDate.BackColor = System.Drawing.Color.White;
            this.dateboxPresentDate.Checked = true;
            this.dateboxPresentDate.FillColor = System.Drawing.Color.Green;
            this.dateboxPresentDate.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.dateboxPresentDate.ForeColor = System.Drawing.Color.White;
            this.dateboxPresentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateboxPresentDate.Location = new System.Drawing.Point(213, 549);
            this.dateboxPresentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateboxPresentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateboxPresentDate.Name = "dateboxPresentDate";
            this.dateboxPresentDate.Size = new System.Drawing.Size(522, 44);
            this.dateboxPresentDate.TabIndex = 44;
            this.dateboxPresentDate.Value = new System.DateTime(2022, 7, 17, 13, 46, 37, 321);
            this.dateboxPresentDate.ValueChanged += new System.EventHandler(this.dateboxPresentDate_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(213, 658);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 29);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbDB
            // 
            this.cbDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbDB.DefaultText = "";
            this.cbDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDB.Location = new System.Drawing.Point(213, 248);
            this.cbDB.Name = "cbDB";
            this.cbDB.PasswordChar = '\0';
            this.cbDB.PlaceholderText = "";
            this.cbDB.SelectedText = "";
            this.cbDB.Size = new System.Drawing.Size(157, 34);
            this.cbDB.TabIndex = 64;
            // 
            // GenerateInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(773, 724);
            this.Controls.Add(this.cbDB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateboxPresentDate);
            this.Controls.Add(this.cbYB1);
            this.Controls.Add(this.cbYB);
            this.Controls.Add(this.btnGEnerateCert);
            this.Controls.Add(this.tbPP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMB1);
            this.Controls.Add(this.cbDB1);
            this.Controls.Add(this.cbMB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSponsor2);
            this.Controls.Add(this.tbSponsor1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbtMother);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtFather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtCandidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genereateInvoicePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateInvoive";
            this.Load += new System.EventHandler(this.GenerateInvoive_Load);
            this.genereateInvoicePanel.ResumeLayout(false);
            this.genereateInvoicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel genereateInvoicePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbtCandidate;
        private Guna.UI2.WinForms.Guna2TextBox tbtFather;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbtMother;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbSponsor2;
        private Guna.UI2.WinForms.Guna2TextBox tbSponsor1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbOP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2ComboBox cbMB;
        private Guna.UI2.WinForms.Guna2ComboBox cbMB1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox tbPP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGEnerateCert;
        private Guna.UI2.WinForms.Guna2TextBox cbYB;
        private Guna.UI2.WinForms.Guna2TextBox cbYB1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateboxPresentDate;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox cbDB;
    }
}