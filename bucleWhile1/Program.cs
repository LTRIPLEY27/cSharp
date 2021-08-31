using System;

namespace bucleWhile1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random();

            int aleat = number.Next(0, 100);

            Console.WriteLine(aleat);

            Console.WriteLine("Introduzca el numero a verificar?");

            int num = int.Parse(Console.ReadLine());

            while (num != aleat)
            {
                if(num < aleat)
                {
                    Console.WriteLine($"el numero a hallr es mayor a {num}, intentelo de nuevo");
                    Console.WriteLine("Introduzca el numero a verificar?");

                    num = int.Parse(Console.ReadLine());
                } else
                {
                    Console.WriteLine($"el numero a hallar es menor a {num}, intentelo de nuevo");
                    Console.WriteLine("Introduzca el numero a verificar?");

                    num = int.Parse(Console.ReadLine());
                }
                
                
            }

            Console.WriteLine($"Has acertado, el numero era {num}");
            

            /*Programa numero aleatorio entre 0 y 100*/

            /*string response = Console.ReadLine();

            while(response != "no")
            {
                Console.WriteLine("inicia bien");

                Console.WriteLine("name?");

                string name = Console.ReadLine();

                Console.WriteLine($"{name}, Do you  wanna go out of this bucle?");

                response = Console.ReadLine();
            }

            Console.WriteLine("has salido del bucle"); */
        }
    }
}
