using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //PEDIR UN NUMERO ENTERO Y LLAMAR A LA FUNCION FACTORIAL

            int num;
            Console.WriteLine("indique el numero a calcular");
            num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("el factorial es: " + getFactorial(num));



        }

        static double getFactorial(int n)
        {
            if(n <= 1)
            {
                return 1;
            } else
            {
                return n * getFactorial(n - 1); //RECURSIVIDAD CON EL FACTORIAL Y EL NUMERO INICIAL A LA INVERSA
            } 


        }
    }
}
