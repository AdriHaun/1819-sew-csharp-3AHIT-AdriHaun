using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    class Circle : Oval, IInfo
    {
        private double r;
        public double R { get { return r; } set { r = value; } }


        public Circle(string name, string c, double density, double r, double x, double y) : base(name, c, density, r, r, x, y)
        { this.R = r; this.X = x; this.Y = y; this.Name = name; this.Color = c; }

        public override void Draw() { Console.WriteLine("Drawing a circle..."); }

        public override double Area { get { return Math.Pow(r,2)* Math.PI; } }
        public override double Circumference { get { return 2 * Math.PI * 2; } }

        public override string GetShapeInfo()
        {
            return "This is a Circle";
        }

    }
}
