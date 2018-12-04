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

                shapes[0] = new Rectangle("blue", "Recti", 6, 5, 10, 0, 0);
                shapes[1] = new Rectangle("red", "Recto", 6, 5, 10, 0, 0);
                shapes[2] = new Oval("green", "Ovali",  8, 2, 5, 0, 0);
                shapes[3] = new Oval("violet", "Ovalo", 5, 7, 13, 0, 0);
                shapes[4] = new Circle("yellow", "Circli", 7, 3, 0, 0);
                shapes[5] = new Circle("turquoise", "Circlo", 5, 13, 0, 0);

                if (shapes[1] is IScalable scalable)
                {
                    scalable.Scale(2);
                }

                foreach (Shape2D s in shapes)
                {
                    s.Draw();
                    Console.WriteLine("Name: " + s.Name + " | Color: " + s.Color);
                    Console.WriteLine("A: " + s.Area + " U: " + s.Circumference);
                             
                    Console.WriteLine("Mass: " + s.Mass + " | Density: " + s.Density);
                    if (s is IInfo info)
                    {
                        Console.WriteLine(info.GetShapeInfo());
                    }                        
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
