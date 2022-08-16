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
    public partial class invoiceCommunion : Form
    {
        public string Communicant, DCommunion, MCommunion, YCommunion, CParish, CPriest, CDirector, SPriest;


        public invoiceCommunion()
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

        private void pictureboxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureboxPrint, "Print");
        }

        private void pictureboxPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel2);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel2.Width / 2), this.panel2.Location.X);
        }

        private void lblParishPriest_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void invoiceCommunion_Load(object sender, EventArgs e)
        {
            lblConfirmand.Text = Communicant;
            lblDofBirthCommunion.Text = DCommunion;
            lnlMofBirthCommunion.Text = MCommunion;
            lblYofBithCommunion.Text = YCommunion;
            lblParishCommunion.Text = CParish;
            lblOfficiatingPriest.Text = CPriest;
            lblDate.Text = CDirector;
            lblParishPriest.Text = SPriest;
        }
    }
}
