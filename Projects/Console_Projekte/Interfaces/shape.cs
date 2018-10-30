using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    abstract class Shape
    {
        private string color;
        private string name;

        public Shape(string color, string name) { Color = color; Name = name; }

        public string Color { get; set; }
        public string Name { get; set; }

        public abstract void Draw();
    }
}
