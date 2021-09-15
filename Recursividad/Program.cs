using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("la suma del numero y de sus sucesivos..." + Calculo(num));


            Console.ReadKey();
        }

        static int Calculo(int n)
        {

            if(n == 1)
            {
                return 1;
               
            }

            Console.WriteLine("el valor de m es " + n);
            return n + Calculo(n - 1);
        }
    }
}
