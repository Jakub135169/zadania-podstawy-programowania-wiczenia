using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_1_pp_03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b , c;
            Console.WriteLine("podaj pierwszą liczbę: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbe; ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj trzecią liczbę: ");
            c = Convert.ToDouble(Console.ReadLine());

            double average = (a + b + c) / 3;
            Console.WriteLine("średnia tych liczb to: " + average);
            Console.ReadLine(); 
        }

    }
}
