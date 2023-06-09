using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_3_pp__03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double W, H, BMI;
            Console.WriteLine("PODAJ SWÓJ WZROST W METRACH");
            H = Convert.ToDouble(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("PODAJ SWOJĄ WAGĘ W KILOGRAMACH");
            W = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            BMI = W / (H * H);
            if (H <= 2)
            {
                Console.WriteLine("TWOJE BMI TO:" + BMI);
            }
            else
            {
                Console.WriteLine("treść zadania wskazała maksymalny wzrost jako 2m");
               
            }
            Console.ReadLine();

            
        }
    }
}
