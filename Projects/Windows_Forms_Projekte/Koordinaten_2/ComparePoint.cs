using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
/*
namespace PointCoords
{
    class ReferencePointComparer:IComparer
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
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }
        
        public int Compare(object obj1, object obj2)
        {
            if(obj1 == null && obj2 == null) return 0;
            if(obj1 == null) return 1;
            if(obj2 == null) return -1;

            if (!(obj1 is Point) ||  !(obj2 is Point) )
                    {       
					    throw (new ArgumentException("Both objects being compared must be of type Point."));
				    }
				    else
                    {   // Vergleich des Abstandes der Punkte vom Referenzpunkt (pref.Xcoord , pref.Ycoord)
                        Point p1 = ;  
                        Point p2 = ;
                        // Quadratische Abstände vom Referenzpunkt (pref.Xcoord , pref.Ycoord)
                        double r2 = ;
                        double r1 = ;

                        if (r1 == r2)       { return (0); }
                        else if (r1 > r2) { return (1); }
                        else if (r1 < r2) { return (-1); }
                  
                  } // else
                return 1;
            } // Compare

    } // class
} // ns
*/