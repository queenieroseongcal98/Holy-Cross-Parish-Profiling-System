namespace HolyCrossParishDesktopApplication
{
    partial class CertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDispose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnCommunion = new System.Windows.Forms.Button();
            this.btnBaptismal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(797, 51);
            this.panel1.TabIndex = 0;
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
            this.btnDispose.Location = new System.Drawing.Point(759, 9);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(26, 29);
            this.btnDispose.TabIndex = 58;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SACRAMENTAL CERTIFICATES and Documents";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmation);
            this.panel2.Controls.Add(this.btnCommunion);
            this.panel2.Controls.Add(this.btnBaptismal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 266);
            this.panel2.TabIndex = 1;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmation.Image")));
            this.btnConfirmation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmation.Location = new System.Drawing.Point(415, 17);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(168, 226);
            this.btnConfirmation.TabIndex = 4;
            this.btnConfirmation.Text = "Certificate of Confirmation";
            this.btnConfirmation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // btnCommunion
            // 
            this.btnCommunion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunion.Image = ((System.Drawing.Image)(resources.GetObject("btnCommunion.Image")));
            this.btnCommunion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCommunion.Location = new System.Drawing.Point(225, 17);
            this.btnCommunion.Name = "btnCommunion";
            this.btnCommunion.Size = new System.Drawing.Size(168, 226);
            this.btnCommunion.TabIndex = 3;
            this.btnCommunion.Text = "Certificate of Communion";
            this.btnCommunion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCommunion.UseVisualStyleBackColor = true;
            this.btnCommunion.Click += new System.EventHandler(this.btnCommunion_Click);
            // 
            // btnBaptismal
            // 
            this.btnBaptismal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaptismal.Image = ((System.Drawing.Image)(resources.GetObject("btnBaptismal.Image")));
            this.btnBaptismal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaptismal.Location = new System.Drawing.Point(27, 17);
            this.btnBaptismal.Name = "btnBaptismal";
            this.btnBaptismal.Size = new System.Drawing.Size(168, 226);
            this.btnBaptismal.TabIndex = 2;
            this.btnBaptismal.Text = "Baptismal Certificate";
            this.btnBaptismal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaptismal.UseVisualStyleBackColor = true;
            this.btnBaptismal.Click += new System.EventHandler(this.btnBaptismal_Click);
            // 
            // CertificateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(797, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CertificateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CertificateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBaptismal;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnCommunion;
        private Guna.UI2.WinForms.Guna2Button btnDispose;
    }
}