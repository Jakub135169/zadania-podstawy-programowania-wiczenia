using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_5_pp_03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("podaj liczbę a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj liczbę b");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Większą jest liczba a=" + a);
                Console.ReadLine();
            }
            else if (a < b)
            {
                Console.WriteLine("Większa jest liczba b=" + b);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("liczby są równe");
                Console.ReadLine();
            }
        }  
    }
}
