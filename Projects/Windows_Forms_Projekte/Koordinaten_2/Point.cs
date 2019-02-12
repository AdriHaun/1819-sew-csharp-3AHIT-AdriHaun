using System;
using System.Collections.Generic;
using System.Text;

namespace PointCoords
{
    public struct Point : IComparable<Point>
    {   // Sortierbar machen des ArrayList of Points
        // Vergleich der Punktabstände vom Ursprung (0,0)

        // X, Y Koordinaten 
        public double Xcoord { get; set; }
        public double Ycoord { get; set; }

        public int CompareTo(Point obj)
        {   // Vergleich des Abstandes der Punkte vom Ursprung (0, 0)
            // Parameter obj in CompareTo(object obj) wird in einen Point konvertiert
            Point p = (Point)obj;
            // Quadratische Abstand vom Ursprung (0, 0) ...
            // ... des betrachteten Punkts (this)
            double r1 = this.Radius;
            // ... des Punktes, der als Parameter übergeben wurde
            double r2 = p.Radius;

            // Vergleich der beiden Punkte und Berechnung des Rückgabewertes von CompareTo(p)
            if (r1 == r2) { return (0); }
            else if (r1 > r2) { return (1); }
            else if (r1 < r2) { return (-1); }
            return 1;
        }

        public double Radius
        {   // Abstand des Punktes vom Ursprung (0, 0)
            get
            {
                return Math.Sqrt(Math.Pow(this.Xcoord, 2) + Math.Pow(this.Ycoord, 2));
            }
        }

    } // Point
}
