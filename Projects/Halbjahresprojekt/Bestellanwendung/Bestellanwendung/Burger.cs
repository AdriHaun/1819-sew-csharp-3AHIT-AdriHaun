﻿using System.Collections.Generic;

namespace Bestellanwendung
{
    public class Burger
    {
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

        public Burger(string nme, string pth, double prc, bool vgi, string algy)
        {
            this.Name = nme;
            this.Path = pth;
            this.Price = prc;
            this.Veg = vgi;
            this.Allergy = algy;
        }
    }
}