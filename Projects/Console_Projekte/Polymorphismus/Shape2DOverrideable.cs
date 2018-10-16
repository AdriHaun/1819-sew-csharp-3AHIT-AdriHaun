using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    class Shape2DOverrideable
    {
        //Variables & Properties
        private string color;
        public string Color { get { return color; } set { color = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        //Ctors
        public Shape2DOverrideable(string name, string c) { this.name = name; this.color = c; }
        public Shape2DOverrideable() { }

        //Methods
        public virtual void Draw () { Console.WriteLine("Cannot draw shape 2D"); }

        public virtual double Area { get { throw new NotImplementedException("Shape2D Are not implemented"); } }
        public virtual double Circumference { get { throw new NotImplementedException("Sahpe2D Area not implemented"); } }
    }
}
