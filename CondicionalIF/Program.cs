using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                bool haceFrio;

                haceFrio = true;

                Console.WriteLine(haceFrio);*/

            int edad;
            Console.WriteLine("evaluaremos si eres mayor o no");
            Console.WriteLine("inserte su edad");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("eres mayor");
            } else
            {
                Console.WriteLine("no eres mayor");
            }
        }
    }
}
