using System;
using System.Collections;
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
        public string sheet = "";
        List<Nahrung> burger = new List<Nahrung>();
        List<Nahrung> wrap = new List<Nahrung>();
        List<Nahrung> sidedishes = new List<Nahrung>();
        List<Nahrung> drinks = new List<Nahrung>();
        List<Nahrung> desserts = new List<Nahrung>();
        List<Nahrung> Cart = new List<Nahrung>();
        Nahrung[] burgerArray = new Nahrung[12];
        Nahrung[] wrapArray = new Nahrung[12];
        Nahrung[] sidedishesArray = new Nahrung[12];
        Nahrung[] drinksArray = new Nahrung[12];
        Nahrung[] dessertsArray = new Nahrung[12];

        public frmMain()
        {
            InitializeComponent();
            pnlMain.BringToFront();
            pnlTopLeft.Visible = false;
            pnlTopMid.Visible = false;
            pnlTopRight.Visible = false;
            pnlBottomLeft.Visible = false;
            pnlBottomMid.Visible = false;
            pnlBottomRight.Visible = false;
            lbxCart.Visible = false;
            cmdAdd.Visible = false;
            cmdRemove.Visible = false;

            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Burger.csv";
            string veg = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";

            burger = pharser.CSVToList(path);
            burgerArray = burger.ToArray();

            if (burgerArray[5].Veg == true) pbxTopRightVeg.BackgroundImage = new Bitmap(veg);
            lblTopRightName.Text = burgerArray[5].Name;
            lblTopRightPrice.Text = Convert.ToString(burgerArray[5].Price) + " €";
            lblTopRightAllergy.Text = burgerArray[5].Allergy;
            cmdTopRight.BackgroundImage = new Bitmap(burgerArray[5].Path);
            pnlTopRight.Visible = true;
            sheet = "Burger";
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

            pnlWrap.BackColor = Color.White;
            pnlSideDishes.BackColor = Color.White;
            pnlDrinks.BackColor = Color.White;
            pnlDesserts.BackColor = Color.White;
            pnlCart.BackColor = Color.White;
            pnlBurger.BackColor = Color.DarkGray;
            lbxCart.Visible = false;
            cmdAdd.Visible = false;
            cmdRemove.Visible = false;
            lblRec.Visible = false;

            sheet = "Burger";
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Burger.csv";
            string veg = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            burger = pharser.CSVToList(path);
            burgerArray = burger.ToArray();
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

            pnlBurger.BackColor = Color.White;
            pnlWrap.BackColor = Color.White;
            pnlSideDishes.BackColor = Color.White;
            pnlDrinks.BackColor = Color.White;
            pnlDesserts.BackColor = Color.White;
            pnlCart.BackColor = Color.White;
            pnlWrap.BackColor = Color.DarkGray;
            lbxCart.Visible = false;
            cmdAdd.Visible = false;
            cmdRemove.Visible = false;
            lblRec.Visible = false;

            sheet = "Wrap";
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Wrap.csv";
            string veg = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            wrap = pharser.CSVToList(path);
            wrapArray = wrap.ToArray();
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

        private void cmdSideDishes_Click(object sender, EventArgs e)
        {
            #region Initialisation
            pbxTopLeftVeg.BackgroundImage = null;
            pbxTopMidVeg.BackgroundImage = null;
            pbxTopRightVeg.BackgroundImage = null;
            pbxBottomLeftVeg.BackgroundImage = null;
            pbxBottomMidVeg.BackgroundImage = null;
            pbxBottomRightVeg.BackgroundImage = null;

            pnlBurger.BackColor = Color.White;
            pnlWrap.BackColor = Color.White;
            pnlDrinks.BackColor = Color.White;
            pnlDesserts.BackColor = Color.White;
            pnlCart.BackColor = Color.White;
            pnlSideDishes.BackColor = Color.DarkGray;
            lbxCart.Visible = false;
            cmdAdd.Visible = false;
            cmdRemove.Visible = false;
            lblRec.Visible = false;

            sheet = "Sidedishes";
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\SideDishes.csv";
            string veg = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            sidedishes = pharser.CSVToList(path);
            sidedishesArray = sidedishes.ToArray();
            int length = sidedishesArray.GetLength(0);
            #region SettingLogic
            if (length >= 1)
            {
                if (sidedishesArray[0].Veg == true) pbxTopLeftVeg.BackgroundImage = new Bitmap(veg);
                lblTopLeftName.Text = sidedishesArray[0].Name;
                lblTopLeftPrice.Text = Convert.ToString(sidedishesArray[0].Price) + " €";
                lblTopLeftAllergy.Text = sidedishesArray[0].Allergy;
                cmdTopLeft.BackgroundImage = new Bitmap(sidedishesArray[0].Path);
                pnlTopLeft.Visible = true;
            }
            else pnlTopLeft.Visible = false;
            if (length >= 2)
            {
                if (sidedishesArray[1].Veg == true) pbxTopMidVeg.BackgroundImage = new Bitmap(veg);
                lblTopMidName.Text = sidedishesArray[1].Name;
                lblTopMidPrice.Text = Convert.ToString(sidedishesArray[1].Price) + " €";
                lblTopMidAllergy.Text = sidedishesArray[1].Allergy;
                cmdTopMid.BackgroundImage = new Bitmap(sidedishesArray[1].Path);
                pnlTopMid.Visible = true;
            }
            else pnlTopMid.Visible = false;
            if (length >= 3)
            {
                if (sidedishesArray[2].Veg == true) pbxTopRightVeg.BackgroundImage = new Bitmap(veg);
                lblTopRightName.Text = sidedishesArray[2].Name;
                lblTopRightPrice.Text = Convert.ToString(sidedishesArray[2].Price) + " €";
                lblTopRightAllergy.Text = sidedishesArray[2].Allergy;
                cmdTopRight.BackgroundImage = new Bitmap(sidedishesArray[2].Path);
                pnlTopRight.Visible = true;
            }
            else pnlTopRight.Visible = false;
            if (length >= 4)
            {
                if (sidedishesArray[3].Veg == true) pbxBottomLeftVeg.BackgroundImage = new Bitmap(veg);
                lblBottomLeftName.Text = sidedishesArray[3].Name;
                lblBottomLeftPrice.Text = Convert.ToString(sidedishesArray[3].Price) + " €";
                lblBottomLeftAllergy.Text = sidedishesArray[3].Allergy;
                cmdBottomLeft.BackgroundImage = new Bitmap(sidedishesArray[3].Path);
                pnlBottomLeft.Visible = true;
            }
            else pnlBottomLeft.Visible = false;
            if (length >= 5)
            {
                if (sidedishesArray[4].Veg == true) pbxBottomMidVeg.BackgroundImage = Image.FromFile(veg);
                lblBottomMidName.Text = sidedishesArray[4].Name;
                lblBottomMidPrice.Text = Convert.ToString(sidedishesArray[4].Price) + " €";
                lblBottomMidAllergy.Text = sidedishesArray[4].Allergy;
                cmdBottomMid.BackgroundImage = new Bitmap(sidedishesArray[4].Path);
                pnlBottomMid.Visible = true;
            }
            else pnlBottomMid.Visible = false;
            if (length >= 6)
            {
                if (sidedishesArray[5].Veg == true) pbxBottomRightVeg.BackgroundImage = new Bitmap(veg);
                lblBottomRightName.Text = sidedishesArray[5].Name;
                lblBottomRightPrice.Text = Convert.ToString(sidedishesArray[5].Price) + " €";
                lblBottomRightAllergy.Text = sidedishesArray[5].Allergy;
                cmdBottomRight.BackgroundImage = new Bitmap(sidedishesArray[5].Path);
                pnlBottomRight.Visible = true;
            }
            else pnlBottomRight.Visible = false;
            #endregion    
        }

        private void cmdDrinks_Click(object sender, EventArgs e)
        {
            #region Initialisation
            pbxTopLeftVeg.BackgroundImage = null;
            pbxTopMidVeg.BackgroundImage = null;
            pbxTopRightVeg.BackgroundImage = null;
            pbxBottomLeftVeg.BackgroundImage = null;
            pbxBottomMidVeg.BackgroundImage = null;
            pbxBottomRightVeg.BackgroundImage = null;

            pnlBurger.BackColor = Color.White;
            pnlWrap.BackColor = Color.White;
            pnlSideDishes.BackColor = Color.White;
            pnlDesserts.BackColor = Color.White;
            pnlCart.BackColor = Color.White;
            pnlDrinks.BackColor = Color.DarkGray;
            lbxCart.Visible = false;
            cmdAdd.Visible = false;
            cmdRemove.Visible = false;
            lblRec.Visible = false;

            sheet = "Drinks";
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Drinks.csv";
            string veg = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            drinks = pharser.CSVToList(path);
            drinksArray = drinks.ToArray();
            int length = drinksArray.GetLength(0);
            #region SettingLogic
            if (length >= 1)
            {
                lblTopLeftName.Text = drinksArray[0].Name;
                lblTopLeftPrice.Text = Convert.ToString(drinksArray[0].Price) + " €";
                lblTopLeftAllergy.Text = drinksArray[0].Allergy;
                cmdTopLeft.BackgroundImage = new Bitmap(drinksArray[0].Path);
                pnlTopLeft.Visible = true;
            }
            else pnlTopLeft.Visible = false;
            if (length >= 2)
            {
                lblTopMidName.Text = drinksArray[1].Name;
                lblTopMidPrice.Text = Convert.ToString(drinksArray[1].Price) + " €";
                lblTopMidAllergy.Text = drinksArray[1].Allergy;
                cmdTopMid.BackgroundImage = new Bitmap(drinksArray[1].Path);
                pnlTopMid.Visible = true;
            }
            else pnlTopMid.Visible = false;
            if (length >= 3)
            {
                lblTopRightName.Text = drinksArray[2].Name;
                lblTopRightPrice.Text = Convert.ToString(drinksArray[2].Price) + " €";
                lblTopRightAllergy.Text = drinksArray[2].Allergy;
                cmdTopRight.BackgroundImage = new Bitmap(drinksArray[2].Path);
                pnlTopRight.Visible = true;
            }
            else pnlTopRight.Visible = false;
            if (length >= 4)
            {
                lblBottomLeftName.Text = drinksArray[3].Name;
                lblBottomLeftPrice.Text = Convert.ToString(drinksArray[3].Price) + " €";
                lblBottomLeftAllergy.Text = drinksArray[3].Allergy;
                cmdBottomLeft.BackgroundImage = new Bitmap(drinksArray[3].Path);
                pnlBottomLeft.Visible = true;
            }
            else pnlBottomLeft.Visible = false;
            if (length >= 5)
            {
                lblBottomMidName.Text = drinksArray[4].Name;
                lblBottomMidPrice.Text = Convert.ToString(drinksArray[4].Price) + " €";
                lblBottomMidAllergy.Text = drinksArray[4].Allergy;
                cmdBottomMid.BackgroundImage = new Bitmap(drinksArray[4].Path);
                pnlBottomMid.Visible = true;
            }
            else pnlBottomMid.Visible = false;
            if (length >= 6)
            {
                lblBottomRightName.Text = drinksArray[5].Name;
                lblBottomRightPrice.Text = Convert.ToString(drinksArray[5].Price) + " €";
                lblBottomRightAllergy.Text = drinksArray[5].Allergy;
                cmdBottomRight.BackgroundImage = new Bitmap(drinksArray[5].Path);
                pnlBottomRight.Visible = true;
            }
            else pnlBottomRight.Visible = false;
            #endregion    
        }

        private void cmdDesserts_Click(object sender, EventArgs e)
        {
            #region Initialisation
            pbxTopLeftVeg.BackgroundImage = null;
            pbxTopMidVeg.BackgroundImage = null;
            pbxTopRightVeg.BackgroundImage = null;
            pbxBottomLeftVeg.BackgroundImage = null;
            pbxBottomMidVeg.BackgroundImage = null;
            pbxBottomRightVeg.BackgroundImage = null;

            pnlBurger.BackColor = Color.White;
            pnlWrap.BackColor = Color.White;
            pnlSideDishes.BackColor = Color.White;
            pnlDrinks.BackColor = Color.White;
            pnlCart.BackColor = Color.White;
            pnlDesserts.BackColor = Color.DarkGray;
            lbxCart.Visible = false;
            cmdAdd.Visible = false;
            cmdRemove.Visible = false;
            lblRec.Visible = false;

            sheet = "Desserts";
            CSVPharser pharser = new CSVPharser();
            string path = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\csv\Desserts.csv";
            string veg = @"C:\repos\1819\1819-sew-csharp-3AHIT-AdriHaun\Projects\Halbjahresprojekt\Bestellanwendung\Bilder\Veggie\Veggie.png";
            #endregion
            desserts = pharser.CSVToList(path);
            dessertsArray = desserts.ToArray();
            int length = dessertsArray.GetLength(0);
            #region SettingLogic
            if (length >= 1)
            {
                lblTopLeftName.Text = dessertsArray[0].Name;
                lblTopLeftPrice.Text = Convert.ToString(dessertsArray[0].Price) + " €";
                lblTopLeftAllergy.Text = dessertsArray[0].Allergy;
                cmdTopLeft.BackgroundImage = new Bitmap(dessertsArray[0].Path);
                pnlTopLeft.Visible = true;
            }
            else pnlTopLeft.Visible = false;
            if (length >= 2)
            {
                lblTopMidName.Text = dessertsArray[1].Name;
                lblTopMidPrice.Text = Convert.ToString(dessertsArray[1].Price) + " €";
                lblTopMidAllergy.Text = dessertsArray[1].Allergy;
                cmdTopMid.BackgroundImage = new Bitmap(dessertsArray[1].Path);
                pnlTopMid.Visible = true;
            }
            else pnlTopMid.Visible = false;
            if (length >= 3)
            {
                lblTopRightName.Text = dessertsArray[2].Name;
                lblTopRightPrice.Text = Convert.ToString(dessertsArray[2].Price) + " €";
                lblTopRightAllergy.Text = dessertsArray[2].Allergy;
                cmdTopRight.BackgroundImage = new Bitmap(dessertsArray[2].Path);
                pnlTopRight.Visible = true;
            }
            else pnlTopRight.Visible = false;
            if (length >= 4)
            {
                lblBottomLeftName.Text = dessertsArray[3].Name;
                lblBottomLeftPrice.Text = Convert.ToString(dessertsArray[3].Price) + " €";
                lblBottomLeftAllergy.Text = dessertsArray[3].Allergy;
                cmdBottomLeft.BackgroundImage = new Bitmap(dessertsArray[3].Path);
                pnlBottomLeft.Visible = true;
            }
            else pnlBottomLeft.Visible = false;
            if (length >= 5)
            {
                lblBottomMidName.Text = dessertsArray[4].Name;
                lblBottomMidPrice.Text = Convert.ToString(dessertsArray[4].Price) + " €";
                lblBottomMidAllergy.Text = dessertsArray[4].Allergy;
                cmdBottomMid.BackgroundImage = new Bitmap(dessertsArray[4].Path);
                pnlBottomMid.Visible = true;
            }
            else pnlBottomMid.Visible = false;
            if (length >= 6)
            {
                lblBottomRightName.Text = dessertsArray[5].Name;
                lblBottomRightPrice.Text = Convert.ToString(dessertsArray[5].Price) + " €";
                lblBottomRightAllergy.Text = dessertsArray[5].Allergy;
                cmdBottomRight.BackgroundImage = new Bitmap(dessertsArray[5].Path);
                pnlBottomRight.Visible = true;
            }
            else pnlBottomRight.Visible = false;
            #endregion    
        }

        private void cmdCart_Click(object sender, EventArgs e)
        {
            pnlTopLeft.Visible = false;
            pnlTopMid.Visible = false;
            pnlTopRight.Visible = false;
            pnlBottomLeft.Visible = false;
            pnlBottomMid.Visible = false;
            pnlBottomRight.Visible = false;

            pnlBurger.BackColor = Color.White;
            pnlWrap.BackColor = Color.White;
            pnlSideDishes.BackColor = Color.White;
            pnlDrinks.BackColor = Color.White;
            pnlDesserts.BackColor = Color.White;
            pnlCart.BackColor = Color.DarkGray;
            lbxCart.Visible = true;
            cmdAdd.Visible = true;
            cmdRemove.Visible = true;
            lblRec.Visible = false;

            sheet = "Cart";
        }

        private void cmdTopLeft_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (sheet == "Burger")
                try { Cart.Find(nahrung => nahrung.Name == burgerArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(burgerArray[index]); }
            if (sheet == "Wrap") 
                try { Cart.Find(nahrung => nahrung.Name == wrapArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(wrapArray[index]); }
            if (sheet == "Sidedishes")
                try { Cart.Find(nahrung => nahrung.Name == sidedishesArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(sidedishesArray[index]); }
            if (sheet == "Drinks")
                try { Cart.Find(nahrung => nahrung.Name == drinksArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(drinksArray[index]); }
            if (sheet == "Desserts")
                try { Cart.Find(nahrung => nahrung.Name == dessertsArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(dessertsArray[index]); }

            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void cmdTopMid_Click(object sender, EventArgs e)
        {
            int index = 1;

            if (sheet == "Burger")
                try { Cart.Find(nahrung => nahrung.Name == burgerArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(burgerArray[index]); }
            if (sheet == "Wrap")
                try { Cart.Find(nahrung => nahrung.Name == wrapArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(wrapArray[index]); }
            if (sheet == "Sidedishes")
                try { Cart.Find(nahrung => nahrung.Name == sidedishesArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(sidedishesArray[index]); }
            if (sheet == "Drinks")
                try { Cart.Find(nahrung => nahrung.Name == drinksArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(drinksArray[index]); }
            if (sheet == "Desserts")
                try { Cart.Find(nahrung => nahrung.Name == dessertsArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(dessertsArray[index]); }

            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void cmdTopRight_Click(object sender, EventArgs e)
        {
            int index = 2;

            if (sheet == "Burger")
                try { Cart.Find(nahrung => nahrung.Name == burgerArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(burgerArray[index]); }
            if (sheet == "Wrap")
                try { Cart.Find(nahrung => nahrung.Name == wrapArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(wrapArray[index]); }
            if (sheet == "Sidedishes")
                try { Cart.Find(nahrung => nahrung.Name == sidedishesArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(sidedishesArray[index]); }
            if (sheet == "Drinks")
                try { Cart.Find(nahrung => nahrung.Name == drinksArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(drinksArray[index]); }
            if (sheet == "Desserts")
                try { Cart.Find(nahrung => nahrung.Name == dessertsArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(dessertsArray[index]); }

            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void cmdBottomLeft_Click(object sender, EventArgs e)
        {
            int index = 3;

            if (sheet == "Burger")
                try { Cart.Find(nahrung => nahrung.Name == burgerArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(burgerArray[index]); }
            if (sheet == "Wrap")
                try { Cart.Find(nahrung => nahrung.Name == wrapArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(wrapArray[index]); }
            if (sheet == "Sidedishes")
                try { Cart.Find(nahrung => nahrung.Name == sidedishesArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(sidedishesArray[index]); }
            if (sheet == "Drinks")
                try { Cart.Find(nahrung => nahrung.Name == drinksArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(drinksArray[index]); }
            if (sheet == "Desserts")
                try { Cart.Find(nahrung => nahrung.Name == dessertsArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(dessertsArray[index]); }

            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void cmdBottomMid_Click(object sender, EventArgs e)
        {
            int index = 4;

            if (sheet == "Burger")
                try { Cart.Find(nahrung => nahrung.Name == burgerArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(burgerArray[index]); }
            if (sheet == "Wrap")
                try { Cart.Find(nahrung => nahrung.Name == wrapArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(wrapArray[index]); }
            if (sheet == "Sidedishes")
                try { Cart.Find(nahrung => nahrung.Name == sidedishesArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(sidedishesArray[index]); }
            if (sheet == "Drinks")
                try { Cart.Find(nahrung => nahrung.Name == drinksArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(drinksArray[index]); }
            if (sheet == "Desserts")
                try { Cart.Find(nahrung => nahrung.Name == dessertsArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(dessertsArray[index]); }

            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void cmdBottomRight_Click(object sender, EventArgs e)
        {
            int index = 5;

            if (sheet == "Burger")
                try { Cart.Find(nahrung => nahrung.Name == burgerArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(burgerArray[index]); }
            if (sheet == "Wrap")
                try { Cart.Find(nahrung => nahrung.Name == wrapArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(wrapArray[index]); }
            if (sheet == "Sidedishes")
                try { Cart.Find(nahrung => nahrung.Name == sidedishesArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(sidedishesArray[index]); }
            if (sheet == "Drinks")
                try { Cart.Find(nahrung => nahrung.Name == drinksArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(drinksArray[index]); }
            if (sheet == "Desserts")
                try { Cart.Find(nahrung => nahrung.Name == dessertsArray[index].Name).Anzahl++; } catch (Exception) { Cart.Add(dessertsArray[index]); }

            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                var nahrungs = new List<Nahrung>();

                foreach (var nahrung in burgerArray) if (nahrung != null) nahrungs.Add(nahrung);
                foreach (var nahrung in wrapArray) if (nahrung != null) nahrungs.Add(nahrung);
                foreach (var nahrung in sidedishesArray) if (nahrung != null) nahrungs.Add(nahrung);
                foreach (var nahrung in drinksArray) if (nahrung != null) nahrungs.Add(nahrung);
                foreach (var nahrung in dessertsArray) if (nahrung != null) nahrungs.Add(nahrung);
                
                Cart.Find(nahrung => nahrung.ToString() == lbxCart.SelectedItem.ToString()).Anzahl++;
                lbxMethods.WriteToListBox(Cart, lbxCart);

            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            Cart.Find(nahrung => nahrung.ToString() == lbxCart.SelectedItem.ToString()).Anzahl--;
            lbxMethods.WriteToListBox(Cart, lbxCart);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}