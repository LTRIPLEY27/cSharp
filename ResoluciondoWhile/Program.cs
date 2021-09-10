using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoluciondoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int k = 0;

            Console.WriteLine("Indique su nombre");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("Indique su nombre");
                name = Console.ReadLine();

            } while (!(name == "pepita"));

            Console.WriteLine("Bienvenida pepita");

            ///   BREAK AND CONTINUE
            /* CONDICION DE SALIDA CON UN BREAK */

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"vamos por {i}");
                if(i == 4)
                {
                    Console.WriteLine("esta es la salida {0}", i);
                    Console.WriteLine("Adeu...");
                    break;
                }
            }

            while (k < 5) 
            {
               // Console.WriteLine($"vamos por aca {k}");
                if(k == 2)
                {
                    Console.WriteLine("soy penultimo {0} elemento, ya puedes dilucidar la longitud", k);
                    k++;
                    continue;
                   
                }
                k++;

                Console.WriteLine(k);
            }

            for(int m = 0; m < 5; m++)
            {
                if (m == 3)
                {
                    continue;
                }

                Console.WriteLine("la iteracion " + m);
            }


            // BREAK : ROMPE EL CICLO
            // CONTINUE: HACE EL SALTO DE LA LINEA DONDE SE LE ESPECIFIQUE LA CONDICION

            for (int i = 0; i < 6; i++)
            {
                if(i == 3) { break; }
                Console.WriteLine("iteracion {0}", i);

            }


        }
    }
}
