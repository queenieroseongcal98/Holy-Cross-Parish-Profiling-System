using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolyCrossParishDesktopApplication
{
    public partial class invoice : Form
    {
        public string Candidate, FatherCandidate, MotherCandidate, DBirth, MBirth, YBirth, DBapt, MBapt, YBapt, OPriest, Sponsors1, Sponsors2, Date, PPriest;

        public invoice()
        {
            InitializeComponent();
            //Date = DateTime.Now.ToString("MMMM/d/yyyy");
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel2 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            lblName.Text = Candidate;
            lblFather.Text = FatherCandidate;
            lblMother.Text = MotherCandidate;
            lblDofBirth.Text = DBirth;
            lnlMofBirth.Text = MBirth;
            lblYofBith.Text = YBirth;
            lblDofBaptismal.Text = DBapt;
            lblMofBaptismal.Text = MBapt;
            lblYofBaptismal.Text = YBapt;
            lblSponsor1.Text = Sponsors1;
            lblSponsor2.Text = Sponsors2;
            lblOfficiatingPriest.Text = OPriest;
            lblDate.Text = Date;
            lblParishPriest.Text = PPriest;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblParishPriest_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblOfficiatingPriest_Click(object sender, EventArgs e)
        {

        }

        private void lblDofBaptismal_Click(object sender, EventArgs e)
        {

        }

        private void lblDofBirth_Click(object sender, EventArgs e)
        {

        }

        private void lblFather_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel2.Width / 2), this.panel2.Location.X);
        }

        private void lblMother_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lnlMofBirth_Click(object sender, EventArgs e)
        {

        }

        private void lblYofBith_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lblMofBaptismal_Click(object sender, EventArgs e)
        {

        }

        private void lblYofBaptismal_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lblSponsor1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void lblSponsor2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Print(this.panel2);
        }

        private void pictureboxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureboxPrint, "Print");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
