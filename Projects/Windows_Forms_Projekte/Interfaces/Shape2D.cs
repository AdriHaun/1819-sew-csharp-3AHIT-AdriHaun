﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    abstract class Shape2D : Shape
    {
        public Shape2D(string n, string c, double density) : base(c, n) { this.Density = density; }

        public abstract double Area { get;}
        public abstract double Circumference { get;}

        public double Density { get; set; }
        public double Mass { get { return Area * Density; } }
    }
}
