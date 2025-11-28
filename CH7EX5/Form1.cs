using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH7EX5
{
    public partial class FineForOverdueBooks : Form
    {
        public FineForOverdueBooks()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double book = 0, day = 0;
            book = double.Parse(txtBooks.Text);
            day = double.Parse(txtDays.Text);
            DisplayFine(book, day);
        }

        private void DisplayFine(double books, double days)
        {
            double fine = 0;
            if (days <= 7)
            {
                fine = ((0.10 * days) * books);
                lblOverdue.Text = ("The fine for " + books + " book(s) for " + days + " day(s) is " + fine.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            }
            else
            {
                if (days > 7)
                {
                    fine = ((0.20 * (days - 7)) * books) + ((0.10 * 7) * books);
                    lblOverdue.Text = ("The fine for " + books + " books(s) for " + days + " day(s) is " + fine.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                }
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
