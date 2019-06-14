using System.Collections.Generic;

namespace Bestellanwendung
{
    public class Nahrung
    {
        #region Properties
        private int anzahl = 0;
        
        public int Anzahl
        {
            get { return anzahl; }
            set { Anzahl = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private bool veg;

        public bool Veg
        {
            get { return veg; }
            set { veg = value; }
        }

        private string allergy;

        public string Allergy
        {
            get { return allergy; }
            set { allergy = value; }
        }
        #endregion
        public Nahrung(string nme, string pth, double prc, bool vgi, string algy)
        {
            this.Name = nme;
            this.Path = pth;
            this.Price = prc;
            this.Veg = vgi;
            this.Allergy = algy;
        }

        public override string ToString()
        {
            return $"{name}: {anzahl} x {price * anzahl}";
        }
    }
}
           