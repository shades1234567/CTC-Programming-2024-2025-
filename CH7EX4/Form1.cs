using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH7EX4
{
    public partial class FortuneTeller : Form
    {
        public FortuneTeller()
        {
            InitializeComponent();
        }

        private void btnFortune_Click(object sender, EventArgs e)
        {
            lblfortune.Text = string.Empty;
            string[] fortunes = {"I see great success!", "I see a potential lover!",
         "I see a man/woman who seems accomplished!", "I see a promotion!", "I see another fortune cookie!"};
            fortuneTeller(fortunes);
        }
        private void fortuneTeller(string[] fortune)
        {
            Random random = new Random();
            int x = random.Next(0, 5);
            int b = random.Next(0, 5);
            lblfortune.Text += (fortune[x]);
            lblfortune.Text += ("\n");
            lblfortune.Text += (fortune[b]);
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
