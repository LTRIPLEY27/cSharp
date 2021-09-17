using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {

            //Stack persons = new Stack();

            ClsPersona[] personas = new ClsPersona[3];

            for(int i = 0; i < personas.Length; i++)
            {

                Console.WriteLine($"indique su nombre {i+1}");
                string name = Console.ReadLine();

                Console.WriteLine($"indique su edad {i+1}");
                int edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"indique su DNI {i + 1}");
                string dni = Console.ReadLine();

                Console.WriteLine($"indique su sexo, con la inicial del mismo {i + 1}");
                char sex = Convert.ToChar(Console.ReadLine());                
                Console.WriteLine($"indique su peso{i + 1}");
                float weight = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"indique su altura {i + 1}");
                float height = (float)Convert.ToDouble(Console.ReadLine());

                personas[i] = new ClsPersona(name, edad, dni, sex, weight, height);

            }

            for(int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].toString());
            }
        }
    }
}
