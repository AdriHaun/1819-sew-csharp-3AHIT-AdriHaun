using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable_Kreis
{
    class Kreis : IEquatable<Kreis>
    {
        public double Radius {get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public double Area { get { return Radius * Radius * Math.PI; } }
        public double Circumfernce { get { return 2 * Radius * Math.PI; } }

        public Kreis(double radius, string color, string name, double xCoord, double yCoord)
        {
            this.Radius = radius;
            this.Color = color;
            this.Name = name;
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        bool IEquatable<Kreis>.Equals(Kreis other)
        {
            return Equals(other);
        }

        public bool Equals(Kreis other)
        {
            if (ReferenceEquals(other, null)) return false;
            else return (this.Radius == other.Radius && this.Color == other.Color && this.XCoord == other.XCoord && this.YCoord == other.YCoord);
        }

        public override bool Equals(Object other)
        {
            Kreis kreis = other as Kreis;
            if (ReferenceEquals(other, null)) return false;
            else return Equals(kreis);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
