using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroAzarFunciones
{
    class Program
    {/*Activitat 2:L’exercici anterior d’un altre grupi passar-ho a funcions.Funcions a definirper quan sí es vol jugar, per exemple:1-Funcióbenvinguda () sense paràmetres i amb return.2-Generador del número aleatori (sense paràmetres i amb return)3-Funció per desar els números que es van introduïnt en un array (amb paràmetres i sense return).4-Funció per valorar si ha encertat (amb paràmetres i amb return, retorna un booleà)5-Missatge de sortida (amb dos paràmetres i sense return) */
        static void Main(string[] args)
        {
            Stack coleccion = new Stack();

            int longi, aleatorio, eleccion, cont = 0;

            Console.WriteLine("Hola " + Bienvenida());


            Console.WriteLine(StartTheGame());


            Console.WriteLine("El numero aleatorio es: " + MiAleatorio());

            aleatorio = MiAleatorio(); // PREGUNTAR EL PORQUE NO PUEDO USAR DIRECTAMENTE EL VALOR ALMACENADO EN EL METODO EN OTRO METODO, O COMO SE HACE?

            /*do {
                Console.WriteLine("cuantas veces desea ponerse a prueba?");
                            eleccion = Convert.ToInt16(Console.ReadLine());
            } while (eleccion > 11);*/
            
            

            Console.WriteLine("prueba tu suerte");
            longi = Convert.ToInt16(Console.ReadLine());
            MiColeccion(coleccion, longi);

            Console.WriteLine(Verifica(longi, aleatorio));


        
            
            
        }


        static void StartTheGame()
        {
            int eleccion;
            string response;

            Console.WriteLine("Desea probar su suerte?");
            response = Console.ReadLine().ToLower();

            if (response == "si")
            {
                do
                {
                    Console.WriteLine("cuantas veces desea ponerse a prueba?");
                    eleccion = Convert.ToInt16(Console.ReadLine());
                } while (eleccion > 11);
            } else
            {
                Console.WriteLine("Debe de ingresar un maximo de 10 intentos");
            }
            
        }
        static string Bienvenida()
        {
            Console.WriteLine("indica tu nombre");
            string name = Console.ReadLine();
            return name;
        }

        static int MiAleatorio()
        {
            Random num = new Random();
            int aleatorio = num.Next(1, 10);
            return aleatorio;
        }

        static void MiColeccion(Stack coleccion, int longi)
        {

            coleccion.Push(longi);

            foreach(int num in coleccion)
            {
                Console.WriteLine(num);
            }

        }

        static bool Verifica(int a, int b)
        {
            bool respuesta = false;
            if (a == b)
            {
                respuesta = true;
            } else
            {
                respuesta = false;
            }

                return respuesta;
        }
    }
}
