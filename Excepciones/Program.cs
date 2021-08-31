using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CAPTURA Y MANEJO DE EXCEPCIONES EN CSHARP*/

            Random num = new Random();

            int aleatorio = num.Next(0, 100);

            int intent = 0;

            int miNum = 0;  // SE INICIA EN 0 PUES CON LA EXCEPCION, EN CASO DE DARSE, DARA ERROR PUES NUNCA SE INICIO LA VARIABLE, !!! OJO !!!

            Console.WriteLine("introduce numero hasta el 100");

            do
            {
                intent++;

                try
                {
                    miNum = int.Parse(Console.ReadLine());
                    if (miNum > aleatorio) Console.WriteLine("el numero es mas bajo");

                    if (miNum < aleatorio) Console.WriteLine("el num es mas alto");
                } 
                catch(FormatException ex)
                {
                    Console.WriteLine("EL FORMANO DEBE DE SER NECESARIAMENTE UN NUMERO");
                   // miNum = 0;
                }
            
               
            } while (aleatorio != miNum);

            Console.WriteLine($"correcto, el numero es {miNum}");
        


        }
    }
}
