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

namespace CH7EX2
{
    public partial class PaintingEstimate : Form
    {
        public PaintingEstimate()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int length = 0, width = 0;
            length = int.Parse(txtLength.Text);
            width = int.Parse(txtWidth.Text);
            costEstimate(length, width);
        }
        private void costEstimate(int len, int wid)
        {
            int longWall = 0, shortWall = 0, cost = 0, area = 0;
            longWall = 2 * (9 * len);
            shortWall = 2 * (9 * wid);
            area = shortWall + longWall;
            cost = area * 6;
            lblCost.Text = ("Cost of a job for " + len + " X " + wid + " foot room is " + cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
