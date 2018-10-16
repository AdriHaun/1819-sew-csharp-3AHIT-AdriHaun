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
                Shape2DOverrideable[] shapes= new Shape2DOverrideable[6];

                shapes[0] = new Rectangle("Rechti", "blue", 5, 10, 0, 0);
                shapes[1] = new Rectangle("Rechto", "red", 13.5, 7, 0, 0);
                shapes[2] = new Oval("Ovali", "green", 2, 5, 0, 0);
                shapes[3] = new Oval("Ovalo", "violet", 7, 13, 0, 0);
                shapes[4] = new Circle("Circli", "yellow", 3, 0, 0);
                shapes[5] = new Circle("Circlo", "turquoise", 13, 0, 0);

                foreach (Shape2DOverrideable s in shapes)
                {
                    s.Draw();
                    Console.WriteLine("Name: " + s.Name + " | Color: " + s.Color);
                    Console.WriteLine("A: " + s.Area + " U: " + s.Circumference);
                    Console.WriteLine();
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
