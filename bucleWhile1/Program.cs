using System;

namespace bucleWhile1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random();

            int aleat = number.Next(0, 100);
            int cont = 0;

            Console.WriteLine(aleat);

            Console.WriteLine("Introduzca el numero a verificar?");

            int num = int.Parse(Console.ReadLine());
            cont++;

            while (num != aleat)
            {
                if(num < aleat)
                {
                    Console.WriteLine($"el numero a hallar es mayor a {num}, intentelo de nuevo");
                    Console.WriteLine("Introduzca el numero a verificar?");

                    num = int.Parse(Console.ReadLine());
                    cont++;
                } else
                {
                    Console.WriteLine($"el numero a hallar es menor a {num}, intentelo de nuevo");
                    Console.WriteLine("Introduzca el numero a verificar?");

                    num = int.Parse(Console.ReadLine());
                    cont++;
                }
                
                
            }

            Console.WriteLine($"Has acertado, el numero era {num}, el numero de intento que te ha costado han sido: {cont}");
            

            /*Programa numero aleatorio entre 0 y 100*/  //CAMBIOS DE IDE

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
