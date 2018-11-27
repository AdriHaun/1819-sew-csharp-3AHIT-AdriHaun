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

                shapes[0] = new Rectangle("blue", "Rectangle1", 5, 7, 12, 0, 0);
                shapes[1] = new Rectangle("pink", "Rectangle2", 6, 17.5, 8, 0, 0);
                shapes[2] = new Oval("green", "Oval1",  3, 4, 6, 0, 0);
                shapes[3] = new Oval("violet", "Oval2", 7, 5, 15, 0, 0);
                shapes[4] = new Circle("orange", "Circle1", 8, 7, 0, 0);
                shapes[5] = new Circle("yellow", "Circle2", 9, 5, 0, 0);

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
