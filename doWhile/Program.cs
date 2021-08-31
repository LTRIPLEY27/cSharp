using System;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            int a = 10;

            do
            {  // LA ENTRADA DENTRO DEL BUCLE INICIA SIN NECESIDAD DE QUE SEA CIERTO O FALSO LA PRIMERA VEZ
                Console.WriteLine("Impresion: " + a);
                a++;
            } while (a < 15);
        }
    }
}
