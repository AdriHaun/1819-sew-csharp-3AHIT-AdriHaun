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
            #region Initialisation
            pbxTopLeftVeg.BackgroundImage = null;
            pbxTopMidVeg.BackgroundImage = null;
            pbxTopRightVeg.BackgroundImage = null;
            pbxBottomLeftVeg.BackgroundImage = null;
            pbxBottomMidVeg.BackgroundImage = null;
            pbxBottomRightVeg.BackgroundImage = null;
            List<Nahrung> burger = new List<Nahrung>();
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Burger.csv";
            string veg = @"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            burger = pharser.CSVToList(path);
            Nahrung[] burgerArray = burger.ToArray();
            int length = burgerArray.GetLength(0);
            #region SettingLogic
            if (length >= 1)
            {
                if (burgerArray[0].Veg == true) pbxTopLeftVeg.BackgroundImage = new Bitmap(veg);
                lblTopLeftName.Text = burgerArray[0].Name;
                lblTopLeftPrice.Text = Convert.ToString(burgerArray[0].Price) + " €";
                lblTopLeftAllergy.Text = burgerArray[0].Allergy;
                cmdTopLeft.BackgroundImage = new Bitmap(burgerArray[0].Path);
                pnlTopLeft.Visible = true;
            }
            else pnlTopLeft.Visible = false;
            if (length >= 2)
            {
                if (burgerArray[1].Veg == true) pbxTopMidVeg.BackgroundImage = new Bitmap(veg);
                lblTopMidName.Text = burgerArray[1].Name;
                lblTopMidPrice.Text = Convert.ToString(burgerArray[1].Price) + " €";
                lblTopMidAllergy.Text = burgerArray[1].Allergy;
                cmdTopMid.BackgroundImage = new Bitmap(burgerArray[1].Path);
                pnlTopMid.Visible = true;
            }
            else pnlTopMid.Visible = false;
            if (length >= 3)
            {
                if (burgerArray[2].Veg == true) pbxTopRightVeg.BackgroundImage = new Bitmap(veg);
                lblTopRightName.Text = burgerArray[2].Name;
                lblTopRightPrice.Text = Convert.ToString(burgerArray[2].Price) + " €";
                lblTopRightAllergy.Text = burgerArray[2].Allergy;
                cmdTopRight.BackgroundImage = new Bitmap(burgerArray[2].Path);
                pnlTopRight.Visible = true;
            }
            else pnlTopRight.Visible = false;
            if (length >= 4)
            {
                if (burgerArray[3].Veg == true) pbxBottomLeftVeg.BackgroundImage = new Bitmap(veg);
                lblBottomLeftName.Text = burgerArray[3].Name;
                lblBottomLeftPrice.Text = Convert.ToString(burgerArray[3].Price) + " €";
                lblBottomLeftAllergy.Text = burgerArray[3].Allergy;
                cmdBottomLeft.BackgroundImage = new Bitmap(burgerArray[3].Path);
                pnlBottomLeft.Visible = true;
            }
            else pnlBottomLeft.Visible = false;
            if (length >= 5)
            {
                if (burgerArray[4].Veg == true) pbxBottomMidVeg.BackgroundImage = Image.FromFile(veg);
                lblBottomMidName.Text = burgerArray[4].Name;
                lblBottomMidPrice.Text = Convert.ToString(burgerArray[4].Price) + " €";
                lblBottomMidAllergy.Text = burgerArray[4].Allergy;
                cmdBottomMid.BackgroundImage = new Bitmap(burgerArray[4].Path);
                pnlBottomMid.Visible = true;
            }
            else pnlBottomMid.Visible = false;
            if (length >= 6)
            {
                if (burgerArray[5].Veg == true) pbxBottomRightVeg.BackgroundImage = new Bitmap(veg);
                lblBottomRightName.Text = burgerArray[5].Name;
                lblBottomRightPrice.Text = Convert.ToString(burgerArray[5].Price) + " €";
                lblBottomRightAllergy.Text = burgerArray[5].Allergy;
                cmdBottomRight.BackgroundImage = new Bitmap(burgerArray[5].Path);
                pnlBottomRight.Visible = true;
            }
            else pnlBottomRight.Visible = false;
            #endregion
        }

        private void cmdWraps_Click(object sender, EventArgs e)
        {
            #region Initialisation
            pbxTopLeftVeg.BackgroundImage = null;
            pbxTopMidVeg.BackgroundImage = null;
            pbxTopRightVeg.BackgroundImage = null;
            pbxBottomLeftVeg.BackgroundImage = null;
            pbxBottomMidVeg.BackgroundImage = null;
            pbxBottomRightVeg.BackgroundImage = null;
            List<Nahrung> wrap = new List<Nahrung>();
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Wrap.csv";
            string veg = @"C:\repos\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            wrap = pharser.CSVToList(path);
            Nahrung[] wrapArray = wrap.ToArray();
            int length = wrapArray.GetLength(0);
            #region SettingLogic
            if (length >= 1)
            {
                if (wrapArray[0].Veg == true) pbxTopLeftVeg.BackgroundImage = new Bitmap(veg);
                lblTopLeftName.Text = wrapArray[0].Name;
                lblTopLeftPrice.Text = Convert.ToString(wrapArray[0].Price) + " €";
                lblTopLeftAllergy.Text = wrapArray[0].Allergy;
                cmdTopLeft.BackgroundImage = new Bitmap(wrapArray[0].Path);
                pnlTopLeft.Visible = true;
            }
            else pnlTopLeft.Visible = false;
            if (length >= 2)
            {
                if (wrapArray[1].Veg == true) pbxTopMidVeg.BackgroundImage = new Bitmap(veg);
                lblTopMidName.Text = wrapArray[1].Name;
                lblTopMidPrice.Text = Convert.ToString(wrapArray[1].Price) + " €";
                lblTopMidAllergy.Text = wrapArray[1].Allergy;
                cmdTopMid.BackgroundImage = new Bitmap(wrapArray[1].Path);
                pnlTopMid.Visible = true;
            }
            else pnlTopMid.Visible = false;
            if (length >= 3)
            {
                if (wrapArray[2].Veg == true) pbxTopRightVeg.BackgroundImage = new Bitmap(veg);
                lblTopRightName.Text = wrapArray[2].Name;
                lblTopRightPrice.Text = Convert.ToString(wrapArray[2].Price) + " €";
                lblTopRightAllergy.Text = wrapArray[2].Allergy;
                cmdTopRight.BackgroundImage = new Bitmap(wrapArray[2].Path);
                pnlTopRight.Visible = true;
            }
            else pnlTopRight.Visible = false;
            if (length >= 4)
            {
                if (wrapArray[3].Veg == true) pbxBottomLeftVeg.BackgroundImage = new Bitmap(veg);
                lblBottomLeftName.Text = wrapArray[3].Name;
                lblBottomLeftPrice.Text = Convert.ToString(wrapArray[3].Price) + " €";
                lblBottomLeftAllergy.Text = wrapArray[3].Allergy;
                cmdBottomLeft.BackgroundImage = new Bitmap(wrapArray[3].Path);
                pnlBottomLeft.Visible = true;
            }
            else pnlBottomLeft.Visible = false;
            if (length >= 5)
            {
                if (wrapArray[4].Veg == true) pbxBottomMidVeg.BackgroundImage = Image.FromFile(veg);
                lblBottomMidName.Text = wrapArray[4].Name;
                lblBottomMidPrice.Text = Convert.ToString(wrapArray[4].Price) + " €";
                lblBottomMidAllergy.Text = wrapArray[4].Allergy;
                cmdBottomMid.BackgroundImage = new Bitmap(wrapArray[4].Path);
                pnlBottomMid.Visible = true;
            }
            else pnlBottomMid.Visible = false;
            if (length >= 6)
            {
                if (wrapArray[5].Veg == true) pbxBottomRightVeg.BackgroundImage = new Bitmap(veg);
                lblBottomRightName.Text = wrapArray[5].Name;
                lblBottomRightPrice.Text = Convert.ToString(wrapArray[5].Price) + " €";
                lblBottomRightAllergy.Text = wrapArray[5].Allergy;
                cmdBottomRight.BackgroundImage = new Bitmap(wrapArray[5].Path);
                pnlBottomRight.Visible = true;
            }
            else pnlBottomRight.Visible = false;
            #endregion
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
