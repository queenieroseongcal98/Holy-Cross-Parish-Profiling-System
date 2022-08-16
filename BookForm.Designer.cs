namespace HolyCrossParishDesktopApplication
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDispose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnameTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.eventBox = new System.Windows.Forms.ComboBox();
            this.placementBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.btnBooktheEvent = new System.Windows.Forms.Button();
            this.contactTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnDispose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDispose
            // 
            this.btnDispose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDispose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDispose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDispose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDispose.FillColor = System.Drawing.Color.Transparent;
            this.btnDispose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDispose.ForeColor = System.Drawing.Color.White;
            this.btnDispose.Image = ((System.Drawing.Image)(resources.GetObject("btnDispose.Image")));
            this.btnDispose.Location = new System.Drawing.Point(768, 5);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(26, 29);
            this.btnDispose.TabIndex = 58;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm an Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // fnameTbox
            // 
            this.fnameTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTbox.DefaultText = "";
            this.fnameTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnameTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnameTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fnameTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameTbox.Location = new System.Drawing.Point(138, 86);
            this.fnameTbox.Name = "fnameTbox";
            this.fnameTbox.PasswordChar = '\0';
            this.fnameTbox.PlaceholderText = "";
            this.fnameTbox.SelectedText = "";
            this.fnameTbox.Size = new System.Drawing.Size(250, 21);
            this.fnameTbox.TabIndex = 2;
            this.fnameTbox.TextChanged += new System.EventHandler(this.fnameTbox_TextChanged);
            // 
            // lnameTbox
            // 
            this.lnameTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTbox.DefaultText = "";
            this.lnameTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnameTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnameTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnameTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameTbox.Location = new System.Drawing.Point(503, 86);
            this.lnameTbox.Name = "lnameTbox";
            this.lnameTbox.PasswordChar = '\0';
            this.lnameTbox.PlaceholderText = "";
            this.lnameTbox.SelectedText = "";
            this.lnameTbox.Size = new System.Drawing.Size(250, 21);
            this.lnameTbox.TabIndex = 4;
            this.lnameTbox.TextChanged += new System.EventHandler(this.lnameTbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Event:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Placement:";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(37, 213);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(147, 21);
            this.lblGuest.TabIndex = 9;
            this.lblGuest.Text = "Number of Guest:";
            // 
            // eventBox
            // 
            this.eventBox.FormattingEnabled = true;
            this.eventBox.Items.AddRange(new object[] {
            "Baptism",
            "First Communion",
            "Confirmation",
            "Wedding",
            "Penance",
            "Annointing"});
            this.eventBox.Location = new System.Drawing.Point(503, 147);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(250, 21);
            this.eventBox.TabIndex = 13;
            this.eventBox.SelectedIndexChanged += new System.EventHandler(this.eventBox_SelectedIndexChanged);
            // 
            // placementBox
            // 
            this.placementBox.FormattingEnabled = true;
            this.placementBox.Items.AddRange(new object[] {
            "Outdoor",
            "Indoor",
            "Church"});
            this.placementBox.Location = new System.Drawing.Point(505, 213);
            this.placementBox.Name = "placementBox";
            this.placementBox.Size = new System.Drawing.Size(250, 21);
            this.placementBox.TabIndex = 14;
            this.placementBox.SelectedIndexChanged += new System.EventHandler(this.placementBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Note:";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(96, 352);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(657, 142);
            this.noteBox.TabIndex = 18;
            this.noteBox.Text = "";
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // btnBooktheEvent
            // 
            this.btnBooktheEvent.BackColor = System.Drawing.Color.Green;
            this.btnBooktheEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooktheEvent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooktheEvent.ForeColor = System.Drawing.Color.White;
            this.btnBooktheEvent.Location = new System.Drawing.Point(587, 540);
            this.btnBooktheEvent.Name = "btnBooktheEvent";
            this.btnBooktheEvent.Size = new System.Drawing.Size(127, 30);
            this.btnBooktheEvent.TabIndex = 19;
            this.btnBooktheEvent.Text = "Book Event";
            this.btnBooktheEvent.UseVisualStyleBackColor = false;
            this.btnBooktheEvent.Click += new System.EventHandler(this.btnBooktheEvent_Click);
            // 
            // contactTbox
            // 
            this.contactTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactTbox.DefaultText = "";
            this.contactTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTbox.Location = new System.Drawing.Point(192, 147);
            this.contactTbox.Name = "contactTbox";
            this.contactTbox.PasswordChar = '\0';
            this.contactTbox.PlaceholderText = "";
            this.contactTbox.SelectedText = "";
            this.contactTbox.Size = new System.Drawing.Size(198, 21);
            this.contactTbox.TabIndex = 20;
            this.contactTbox.TextChanged += new System.EventHandler(this.contactTbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Time:";
            // 
            // timeTbox
            // 
            this.timeTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeTbox.DefaultText = "";
            this.timeTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeTbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeTbox.Location = new System.Drawing.Point(503, 277);
            this.timeTbox.Name = "timeTbox";
            this.timeTbox.PasswordChar = '\0';
            this.timeTbox.PlaceholderText = "";
            this.timeTbox.SelectedText = "";
            this.timeTbox.Size = new System.Drawing.Size(250, 21);
            this.timeTbox.TabIndex = 22;
            this.timeTbox.TextChanged += new System.EventHandler(this.timeTbox_TextChanged);
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(192, 213);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(198, 21);
            this.guna2TextBox6.TabIndex = 23;
            // 
            // BookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(797, 620);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.timeTbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.contactTbox);
            this.Controls.Add(this.btnBooktheEvent);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.placementBox);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnameTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fnameTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox fnameTbox;
        private Guna.UI2.WinForms.Guna2TextBox lnameTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.ComboBox eventBox;
        private System.Windows.Forms.ComboBox placementBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.Button btnBooktheEvent;
        private Guna.UI2.WinForms.Guna2Button btnDispose;
        private Guna.UI2.WinForms.Guna2TextBox contactTbox;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox timeTbox;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
    }
}