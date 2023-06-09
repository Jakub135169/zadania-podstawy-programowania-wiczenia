using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_nr_6_pp_03._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double a, b, c;

            Console.WriteLine("podaj długośc boku a ");
            a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj długośc boku b");
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj długość boku c");
            c= Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("podane długości boków pozwalają stworzyć trójkąt równoboczny");
                Console.ReadLine();
            }
            else if ( a != b && b == c) 
            {
                Console.WriteLine("niestety długośc boku a jest nieodpowiednia");
                Console.ReadLine();
            }
            else if ( a ==c  && b != c)
            {
                Console.WriteLine("niestety długośc boku b jest nieodpowiednia");
                Console.ReadLine();
            }
            else if (a == b && c != b)
            {
                Console.WriteLine("niestety długośc boku c jest nieodpowiednia");
                Console.ReadLine();
            }

        }
    }
}
