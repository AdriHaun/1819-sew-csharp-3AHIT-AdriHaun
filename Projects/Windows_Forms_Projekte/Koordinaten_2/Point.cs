using System;
using System.Collections.Generic;
using System.Text;

namespace PointCoords
{
    public struct Point : IComparable<Point>
    {   // Sortierbar machen des ArrayList of Points
        // Vergleich der Punktabstände vom Ursprung (0,0)

        // X, Y Koordinaten ....
        private double xcoord;
        private double ycoord;

        private double r1;
        private double r2;

        public double Xcoord
        {
            get { return xcoord; }
            set { xcoord = value; }
        }

        public double Ycoord
        {
            get { return ycoord; }
            set { ycoord = value; }
        }

        public int CompareTo(Point obj)
        {
            Point p =  obj;

            double r1 = this.Radius;
            double r2 = p.Radius;

            // Vergleich der beiden Punkte und Berechnung des Rückgabewertes von CompareTo(p)
            if (r1 == r2)       { return (0); }
            else if (r1 > r2)   { return (1); }
            else if (r1 < r2)   { return (-1);}
            return 1;
        } // CompareTo

        public double Radius
        {   // Abstand des Punktes vom Ursprung (0, 0)
            get
            {
                return Math.Sqrt(Math.Pow(Xcoord, 2) + Math.Pow(Ycoord, 2));
            }
        }

    } // Point
}
