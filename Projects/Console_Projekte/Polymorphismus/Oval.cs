using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    class Oval : Shape2DOverrideable
    {
        //Variables & Properties
        private double a;
        public double A { get { return a; } set { a = value; } }

        private double b;
        public double B { get { return b; } set { b = value; } }

        public double X { get; set; }
        public double Y { get; set; }

        //Ctors
        public Oval(double a, double b, double x, double y) { this.A = a; this.B = b; this.X = x; this.Y = y; }
        public Oval(double a, double b) : this(a, b, 0, 0) { }
        public Oval(string name, string c, double a, double b, double x, double y) : base(name, c)
        { this.A = a; this.B = b; this.X = x; this.Y = y; }
        public Oval() { }

        //Methods
        public override void Draw() { Console.WriteLine("Draving an Oval..."); }

        public override double Area { get { return a * b * Math.PI; } }
        public override double Circumference { get { return (Math.PI * Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2) * 2))); } }
    }
}
