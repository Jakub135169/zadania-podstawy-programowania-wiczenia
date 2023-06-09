using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;

namespace zadanie_nr_7_03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("podaj współrzędną x P(...,y)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj współrzędną y P(" + x + ",...)");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("P(" + x + "," + y + "). Następnie podaj promień koła r =");
            int r = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;

            Point P = new Point(x, y);
            Point O = new Point(a, b);

            if ((x - a) * (x - a) + ((y - b) * (y - b)) == (r * r))
            {
                Console.WriteLine("Punkt P(" + x +"," + y + ") znajduje sie w kole o środku O i promieniu" + r);
                Console.ReadLine();
            }
            else
            { 
                Console.WriteLine("Punkt P(" + x +"," + y + ") nie znajduje sie w kole o środku O i promieniu" + r);
                Console.ReadLine();
            }
            

            


        }
    }
}
