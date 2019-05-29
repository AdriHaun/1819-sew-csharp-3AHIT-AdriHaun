using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestellanwendung
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            pnlBurger.Visible = true;
        }

        private void cmdBurger_Click(object sender, EventArgs e)
        {
            pnlBurger.Visible = true;
        }

        private void cmdWraps_Click(object sender, EventArgs e)
        {

        }

        private void cmdChicken_Click(object sender, EventArgs e)
        {

        }

        private void cmdDrinks_Click(object sender, EventArgs e)
        {

        }

        private void cmdDesserts_Click(object sender, EventArgs e)
        {

        }

        private void cmdCart_Click(object sender, EventArgs e)
        {

        }
    }
}
