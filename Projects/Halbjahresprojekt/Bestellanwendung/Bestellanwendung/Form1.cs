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
            pnlBurger.BringToFront();
        }

        private void cmdBurger_Click(object sender, EventArgs e)
        {
            cmdHamburger.BackgroundImage = new Bitmap(@"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Burger\Chickenburger.png");
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

        private void pnlBurger_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
