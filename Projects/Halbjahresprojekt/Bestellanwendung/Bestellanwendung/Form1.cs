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
            pnlMain.BringToFront();
        }

        private void cmdBurger_Click(object sender, EventArgs e)
        {
            List<Burger> burger = new List<Burger>();
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Burger.csv";
            string veg = @"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Veggie\Veggie.png";
            burger = pharser.CSVToList(path);
            Burger[] burgerArray = burger.ToArray();

            if (burgerArray[0].Veg == true)pbxTopLeftVeg.BackgroundImage = new Bitmap(veg);
            lblTopLeftName.Text = burgerArray[0].Name;
            lblTopLeftPrice.Text = Convert.ToString(burgerArray[0].Price) + " €";
            lblTopLeftAllergy.Text = burgerArray[0].Allergy;
            cmdTopLeft.BackgroundImage = new Bitmap(burgerArray[0].Path);

            if (burgerArray[1].Veg == true) pbxTopMidVeg.BackgroundImage = new Bitmap(veg);
            lblTopMidName.Text = burgerArray[1].Name;
            lblTopMidPrice.Text = Convert.ToString(burgerArray[1].Price) + " €";
            lblTopMidAllergy.Text = burgerArray[1].Allergy;
            cmdTopMid.BackgroundImage = new Bitmap(burgerArray[1].Path);

            if (burgerArray[2].Veg == true) pbxTopRightVeg.BackgroundImage = new Bitmap(veg);
            lblTopRightName.Text = burgerArray[2].Name;
            lblTopRightPrice.Text = Convert.ToString(burgerArray[2].Price) + " €";
            lblTopRightAllergy.Text = burgerArray[2].Allergy;
            cmdTopRight.BackgroundImage = new Bitmap(burgerArray[2].Path);

            
            if (burgerArray[0].Veg == true) pbxTopLeftVeg.BackgroundImage = new Bitmap(veg);
            lblTopLeftName.Text = burgerArray[0].Name;
            lblTopLeftPrice.Text = Convert.ToString(burgerArray[0].Price) + " €";
            lblTopLeftAllergy.Text = burgerArray[0].Allergy;
            cmdTopLeft.BackgroundImage = new Bitmap(burgerArray[0].Path);

            if (burgerArray[1].Veg == true) pbxTopMidVeg.BackgroundImage = new Bitmap(veg);
            lblTopMidName.Text = burgerArray[1].Name;
            lblTopMidPrice.Text = Convert.ToString(burgerArray[1].Price) + " €";
            lblTopMidAllergy.Text = burgerArray[1].Allergy;
            cmdTopMid.BackgroundImage = new Bitmap(burgerArray[1].Path);

            if (burgerArray[2].Veg == true) pbxTopRightVeg.BackgroundImage = new Bitmap(veg);
            lblTopRightName.Text = burgerArray[2].Name;
            lblTopRightPrice.Text = Convert.ToString(burgerArray[2].Price) + " €";
            lblTopRightAllergy.Text = burgerArray[2].Allergy;
            cmdTopRight.BackgroundImage = new Bitmap(burgerArray[2].Path);
            

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
