using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    public abstract class Shape2D : IMaterial
    {
        //Variables & Properties
        private string color;
        public string Color { get { return color; } set { color = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        //Ctors
        public Shape2D(string name, string c, double Density) { this.name = name; this.color = c; }
        public Shape2D() { }

        //Methods
        public abstract void Draw ();

        public abstract double Area { get; }
        public abstract double Circumference { get ; }
        public abstract double Density { get; set; }
        public double Mass { get { return Area * Density; } }
    }
}
