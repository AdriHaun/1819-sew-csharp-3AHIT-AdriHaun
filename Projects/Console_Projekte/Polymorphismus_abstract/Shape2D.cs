using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    public abstract class Shape2D
    {
        //Variables & Properties
        private string color;
        public string Color { get { return color; } set { color = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        //Constructors
        public Shape2D(string name, string c) { this.name = name; this.color = c; }
        public Shape2D() { }

        //Methods
        public abstract void Draw ();

        public abstract double Area { get; }
        public abstract double Circumference { get ; }
    }
}
