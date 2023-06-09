using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_nr_8_pp_03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("podaj pierwsza liczbę");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("wybierz działanie");
            Console.WriteLine("1.Dodawanie");
            Console.WriteLine("2.Odejmowanie");
            Console.WriteLine("3.Mnożenie");
            Console.WriteLine("4.Dzielenie");

            string opcja = Console.ReadLine();

            if (opcja == "1")
            {
                double wynikdodawania = a + b;
                Console.WriteLine("wynik dodawania to:" + wynikdodawania);
                Console.ReadLine();


            }
            else if (opcja == "2")
            {
                double wynikodejmowania = a - b;
                Console.WriteLine("wynik odejmowania to:" + (wynikodejmowania));
                Console.ReadLine();

            }
            else if (opcja == "3")
            {
                double wynikmnozenia = a * b;
                Console.WriteLine("wynik mnożenia to:" + wynikmnozenia);
                Console.ReadLine();

            }
            else if (opcja == "4")
            {
                double wynikdzielenia = a / b;
                if (b != 0)
                {
                    wynikdzielenia = a / b;
                }
                else
                {
                    Console.WriteLine($"wynik dzielenia przez zero wg zadania zapisany: {a}/0");
                    Console.ReadLine();
                    
                    
                }




            }








        }
    }
}
