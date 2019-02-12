using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PointCoords
{
    class ReferencePointComparer : IComparer<Point>
    {
        private Point pref = new Point();

        public ReferencePointComparer()
        {
            this.pref.Xcoord = 0;
            this.pref.Ycoord = 0;
        }

        public ReferencePointComparer(double x, double y)
        {
            this.pref.Xcoord = x;
            this.pref.Ycoord = y;
        }

        public double X
        {
            get { return pref.Xcoord; }
            set { pref.Xcoord = value; }
        }

        public double Y
        {
            get { return pref.Ycoord; }
            set { pref.Ycoord = value; }
        }

        public int Compare(Point obj1, Point obj2)
        {
            // Vergleich des Abstandes der Punkte vom Referenzpunkt (pref.Xcoord , pref.Ycoord)
            Point p1 = obj1;
            Point p2 = obj2;
            // Quadratische Abstände vom Referenzpunkt (pref.Xcoord , pref.Ycoord)
            double r2 = this.Radius(p2);
            double r1 = this.Radius(p1);

            if (r1 == r2) { return (0); }
            else if (r1 > r2) { return (1); }
            else if (r1 < r2) { return (-1); }

            return 1;
        } // Compare

        public double Radius (Point point)
        {
            double radius;
            Point p1 = new Point();

            p1.Xcoord = point.Xcoord - this.pref.Xcoord;
            p1.Ycoord = point.Ycoord - this.pref.Ycoord;

            radius = p1.Radius;

            return radius;
        }

    } // class
} // ns
