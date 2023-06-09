using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_4_pp_03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź liczbę b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź liczbę c:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź liczbę d:");
            int d = int.Parse(Console.ReadLine());
            Console.Clear();


            if (b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązania");
                Console.ReadLine();
            }
            else
            {
                int x = (a * d) + (b * c);
                int y = b * d;
                Console.WriteLine("licznik x :" + x + " mianownik y :" + y);
                Console.ReadLine();


            }

        }
    }
}

