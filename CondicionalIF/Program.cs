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

                Console.WriteLine(haceFrio);

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
            }*/
            int edad;

            Console.WriteLine("evaluaremos si puedes conducir");

            Console.WriteLine("indique su edad?");
            edad = int.Parse(Console.ReadLine());

            bool carnet = true;

            /*
            if(edad < 18)
            {
                Console.WriteLine("lo siento, estoy notificando a la policia no puedes conducir");
                carnet = false;
                Console.WriteLine(carnet);
            } else
            {
                carnet = true;
                Console.WriteLine("puedes conducir");
                Console.WriteLine(carnet);
            }*/


            // IF ANIDADOS

            /* PROGRAMA QUE EVALUA LA EDAD Y EL CARNET PARA CONDUCIR, EN CASO DE UNA NEGACION CIERRA 
             */

            //int edad;
            string response;
            

            Console.WriteLine("evaluaremos si puedes conducir");

            Console.WriteLine("indique su edad?");
            edad = int.Parse(Console.ReadLine());

            

            if(edad >= 18 )
            {
            Console.WriteLine("posee carnet de conducir");
            response = Console.ReadLine();
                if(response == "si")
                {
                    Console.WriteLine("puedes conducir");
                } else
                {
                    Console.WriteLine("No puedes conducir asi seas mayor de edad es necesario dispongas d eun carnet");
                }
                
            } else
            {
                Console.WriteLine("No puedes ya que eres menor de edad");
            }



        }
    }
}
