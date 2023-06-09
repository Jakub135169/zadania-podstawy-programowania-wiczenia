using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_2__03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, O, r;
            Console.WriteLine("podaj pole kola: ");
            P = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt(P / Math.PI);
            O = 2 * Math.PI * r;
            Console.WriteLine("obwód koła jest równy: " + O + "a jego promień to: " + r);
            Console.ReadLine();
        }
    }
}
