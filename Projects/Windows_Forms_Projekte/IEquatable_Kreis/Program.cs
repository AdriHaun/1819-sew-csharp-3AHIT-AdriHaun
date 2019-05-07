using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable_Kreis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Kreis k1 = new Kreis(10, "pink", "k1", 1, 1);
                Kreis k2 = new Kreis(10, "blue", "k2", 1, 1);
                if (k1 is IEquatable<Kreis> && k2 is IEquatable<Kreis>)
                {
                    Console.WriteLine(k1.Name + ": " + "Radius: " + k1.Radius + " Color: " + k1.Color + " X: " + k1.XCoord + " Y: " + k1.YCoord);
                    Console.WriteLine(k2.Name + ": " + "Radius: " + k2.Radius + " Color: " + k2.Color + " X: " + k2.XCoord + " Y: " + k2.YCoord + "\n");

                    Console.WriteLine((k1.Equals(k2)) ? k1.Name + " und " + k2.Name + " sind gleich (Objekt)" : k1.Name + " und " + k2.Name + " sind nicht gleich (Objekt)");
                    if (k1 as IEquatable<Kreis> != null)
                        Console.WriteLine((k1.Equals(k2)) ? k1.Name + " und " + k2.Name + " sind gleich (Explizit)" : k1.Name + " und " + k2.Name + " sind nicht gleich (Explizit)");
                }

                Console.WriteLine("\n----------------------------------------\n");

                k1 = new Kreis(10, "red", "k1", 1, 1);
                k2 = new Kreis(10, "red", "k2", 1, 1);

                Console.WriteLine(k1.Name + ": " + "Radius: " + k1.Radius + " Color: " + k1.Color + " X: " + k1.XCoord + " Y: " + k1.YCoord);
                Console.WriteLine(k2.Name + ": " + "Radius: " + k2.Radius + " Color: " + k2.Color + " X: " + k2.XCoord + " Y: " + k2.YCoord + "\n");

                Console.WriteLine((k1.Equals(k2)) ? k1.Name + " und " + k2.Name + " sind gleich (Objekt)" : k1.Name + " und " + k2.Name + " sind nicht gleich (Objekt)");
                if (k1 as IEquatable<Kreis> != null)
                    Console.WriteLine((k1.Equals(k2)) ? k1.Name + " und " + k2.Name + " sind gleich (Explizit)" : k1.Name + " und " + k2.Name + " sind nicht gleich (Explizit)");

                Console.WriteLine("\n----------------------------------------\n");

                double r; string c; string n; double x; double y; char wiederholen;

                Console.WriteLine("Kreis 1: ");
                Console.Write("Name: "); n = Console.ReadLine();
                Console.Write("Farbe: "); c = Console.ReadLine();
                Console.Write("Radius: "); r = Convert.ToDouble(Console.ReadLine());
                Console.Write("X: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y: "); y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                k1 = new Kreis(r, c, n, x, y);

                Console.WriteLine("Kreis 2: ");
                Console.Write("Name: "); n = Console.ReadLine();
                Console.Write("Farbe: "); c = Console.ReadLine();
                Console.Write("Radius: "); r = Convert.ToDouble(Console.ReadLine());
                Console.Write("X: "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y: "); y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                k2 = new Kreis(r, c, n, x, y);

                Console.WriteLine(k1.Name + ": " + "Radius: " + k1.Radius + " Color: " + k1.Color + " X: " + k1.XCoord + " Y: " + k1.YCoord);
                Console.WriteLine(k2.Name + ": " + "Radius: " + k2.Radius + " Color: " + k2.Color + " X: " + k2.XCoord + " Y: " + k2.YCoord + "\n");

                Console.WriteLine((k1.Equals(k2)) ? k1.Name + " und " + k2.Name + " sind gleich (Objekt)" : k1.Name + " und " + k2.Name + " sind nicht gleich (Objekt)");
                if (k1 as IEquatable<Kreis> != null)
                    Console.WriteLine((k1.Equals(k2)) ? k1.Name + " und " + k2.Name + " sind gleich (Explizit)" : k1.Name + " und " + k2.Name + " sind nicht gleich (Explizit)");

                Console.Write("\nWiederholen? (J/N): "); wiederholen = Convert.ToChar(Console.ReadLine());
                if (wiederholen == 'J' || wiederholen == 'j')
                {
                    Console.Clear();
                    Main(new string[0]);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                Main( new string[0]);
            }
        }
    }
}