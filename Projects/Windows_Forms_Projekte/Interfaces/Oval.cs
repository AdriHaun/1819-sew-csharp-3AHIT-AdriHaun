using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    class Oval : Shape2D, IInfo, IScalable
    {
        //Variables & Properties
        private double a;
        public double A { get { return a; } set { a = value; } }

        private double b;
        public double B { get { return b; } set { b = value; } }

        public double X { get; set; }
        public double Y { get; set; }

        //Ctors
        public Oval(string name, string c, double density, double a, double b, double x, double y) : base(name, c, density)
        { this.A = a; this.B = b; this.X = x; this.Y = y; }

        //Methods
        public override void Draw() { Console.WriteLine("Draving an Oval..."); }

        string IInfo.GetShapeInfo()
        {
            return "This is an oval";
        }

        void IScalable.Scale(double factor)
        {
            A *= factor;
            B *= factor;
        }

        public override double Area { get { return a * b * Math.PI; } }
        public override double Circumference { get { return (Math.PI * Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2) * 2))); } }
    }
}
