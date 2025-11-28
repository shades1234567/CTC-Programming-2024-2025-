using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH6EX1
{
    public partial class SalesLetter : Form
    {
        public SalesLetter()
        {
            InitializeComponent();
        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayContactInfo()
        {
            lblLetter.Text += ("  From");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("C# Company");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Phone: 555-1234     Cell: 555-0912");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Email: csharpcompany@csharp.com");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("On the Web at www.csharpcompanyforyou.com");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("____________________________");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("                            ");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Dear Client,");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("We want to provide you good service.");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Feel free to contact us at any time.");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("C# Company");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Phone: 555-1234     Cell: 555-0912");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Email: csharpcompany@csharp.com");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("On the Web at www.csharpcompanyforyou.com");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("     *********");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("                                         ");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Looking forward to a long relationship.");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("C# Company");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Phone: 555-1234     Cell: 555-0912");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("Email: csharpcompany@csharp.com");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("On the Web at www.csharpcompanyforyou.com");
            lblLetter.Text += ("\n");
            lblLetter.Text += ("                            ");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayContactInfo();
            DisplayContactInfo();
            DisplayContactInfo();
        }
    }
}
