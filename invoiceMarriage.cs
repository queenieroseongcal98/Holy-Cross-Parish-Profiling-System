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
    public partial class invoiceMarriage : Form
    {

        public string Groom, Bride, MDay, MMonth, MYear, MPriest, MParish, MWitness1, MWitness2, ParMarriage, GSignature, BSignature, W1Signature, PSignature, W2Signature;

        public invoiceMarriage()
        {
            InitializeComponent();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void invoiceMarriage_Load(object sender, EventArgs e)
        {
            lblGroom.Text = Groom;
            lblBride.Text = Bride;
            lblDMarriage.Text = MDay;
            lblMMarriage.Text = MMonth;
            lblYMarriage.Text = MYear;
            lblParishonConfirmation.Text = MPriest;
            lblWitness1.Text = MWitness1;
            lblParishMarriage.Text = ParMarriage;
            lblWitness2.Text = MWitness2;
            lblGSignature.Text = GSignature;
            lblBSignature.Text = BSignature;
            lblW1Signature.Text = W1Signature;
            lblPriestSignature.Text = PSignature;
            lblW2Signature.Text = W2Signature;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureboxPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel2);
        }

        private void lblPriestSignature_Click(object sender, EventArgs e)
        {

        }

        private void lblParishMarriage_Click(object sender, EventArgs e)
        {

        }

        private void lblWitness2_Click(object sender, EventArgs e)
        {

        }

        private void lblW2Signature_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void lblW1Signature_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void lblBSignature_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void lblGSignature_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblWitness1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblBride_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblYMarriage_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel2.Width / 2), this.panel2.Location.X);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureboxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureboxPrint, "Print");
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lblMMarriage_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblParishonConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void lblDMarriage_Click(object sender, EventArgs e)
        {

        }

        private void lblGroom_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelCand_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
