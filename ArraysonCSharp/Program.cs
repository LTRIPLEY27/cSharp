using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysonCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // vectores unidimensionales

            int[] vector = new int [5]; // DEFINICION DEL ARRAY

            string[] listAlumnes = new string[4];

            string[] arrayLetters = new string[28];

            int[] numeros = new int[] { 1, 2, 3, 4, 5 }; // DEFINICION E INICIALIZACION DE UN ARRAY DE ENTEROS.
            Console.WriteLine("la posicion del array es {0}", numeros[3]);

            for (int i = 0; i < 5; i++)
            {
                vector[i] = i;
                Console.WriteLine(vector);
            }

            // RELLENAR LA lisAlumnes con nombres por teclado

            for (int j = 0; j < listAlumnes.Length; j++)
            {
                Console.WriteLine("Nombre de alumno");
                listAlumnes[j] = Console.ReadLine();
            }


            // RECORRE EL ABECEDARIO 
            int h = 0;
            for(char i = 'a'; i < 'z'; i++) // SE DECLARA LA "i" CON ORDEN DESDE LA "A" a "Z" CON EL ORDEN ALFABETICO

            {
                arrayLetters[h] = Convert.ToString(i);
                h++;
            }

            Console.WriteLine(arrayLetters[21]);

            Console.WriteLine($"el alumno numero 3 de la base de datos es: {listAlumnes[2]}");


        }
    }
}
