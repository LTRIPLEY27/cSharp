using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            ///////////  PILAS
            Stack miPila = new Stack();  // DECLARACION DE LA PILA

            miPila.Push("hola"); // METODO "PUSH" : AGREGA ELEMENTOS A LA "PILA" ARRAY
            miPila.Push("buenas..");
            miPila.Push("tardes");

            for(byte i = 0; i < 3; i++)
            {
                palabra = (string)miPila.Pop(); // EL METODO "PEEK" EN EL CASO DE LAS PILAS DEVUELVE EL ULTIMO VALOR ALMACENADO EN LA PILA, INVERSAMENTE A SU ANALOGO DE LA COLA QUE RETORNA EL PRIMERO
                Console.WriteLine(palabra);

            }

            Console.WriteLine("la pila tiene elementos: " + miPila.Count);


            ////////////// COLAS 

            string palabrita;
            Queue miCola = new Queue();  // DECLARACION DE LA COLA
            miCola.Enqueue("hola");
            miCola.Enqueue("buenas");
            miCola.Enqueue("tardes");

            Console.WriteLine("el valor de arriba es : " + miCola.Peek()); // EL METODO "PEEK" ES ANALOGO AL DE LA PILA, SOLO QUE POR ORDEN SACA EL PRIMER VALOR ALMACENADO

            for (int i = 0; i < 3; i++)
            {
                palabrita = (string)miCola.Dequeue();// EL "DEQUEUE" DEVUELVE UN OBJECT GENERICO, POR ELLO RELAIZAMOS EL CASTING PARA LEERSE
                Console.WriteLine(palabrita);
            }

            Console.WriteLine("la cola tiene : " + miCola.Count);

            Console.ReadKey();
        }
    }
}
