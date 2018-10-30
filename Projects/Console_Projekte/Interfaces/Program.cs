using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape2D[] shapes= new Shape2D[6];

                shapes[0] = new Rectangle("blue", "Rechti", 5, 7, 12, 0, 0);
                shapes[1] = new Rectangle("red", "Rechto", 5, 17.5, 8, 0, 0);
                shapes[2] = new Oval("green", "Ovali",  5, 4, 6, 0, 0);
                shapes[3] = new Oval("violet", "Ovalo", 5, 5, 15, 0, 0);
                shapes[4] = new Circle("yellow", "Circli", 5, 7, 0, 0);
                shapes[5] = new Circle("turquoise", "Circlo", 5, 5, 0, 0);

                foreach (Shape2D s in shapes)
                {
                    if (s is IMaterial)
                    {
                        s.Draw();
                        Console.WriteLine("Name: " + s.Name + " | Color: " + s.Color);
                        Console.WriteLine("A: " + s.Area + " U: " + s.Circumference);
                        Console.WriteLine("Mass: " + s.Mass + " | Density: " + s.Density);
                        Console.WriteLine();
                    }
                }

                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
