using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    class Rectangle : Shape2DOverrideable
    {
        //Variables
        private double a;
        private double b;

        //Constructors
        public Rectangle(double a, double b, double x, double y) { this.A = a; this.B = b; this.X = x; this.Y = y; }
        public Rectangle(double a, double b) : this(a, b, 0, 0) { }
        public Rectangle(string name, string c, double a, double b, double x, double y) : base(name, c)
        { this.A = a; this.B = b; this.X = x; this.Y = y; }

        //Properties
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double X { get; set; }
        public double Y { get; set; }

        //Methods
        public override void Draw() { Console.WriteLine("Draving a Rectangle..."); }

        public override double Area { get { return a * b; } }
        public override double Circumference { get { return (a+b)*2; } }

    }
}
