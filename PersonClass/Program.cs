using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIACION DE LAS CLASES
            string nameP, lastP, emailP, nameS, lastS, emailS, facu;
            int codi;


                Console.WriteLine("nombre persona");
                nameP = Console.ReadLine();

                Console.WriteLine("apellido persona");
                lastP = Console.ReadLine();

                Console.WriteLine("email persona");
                emailP = Console.ReadLine();
   

                ClsPerson persona = new ClsPerson(nameP, lastP, emailP);

            Console.WriteLine("nombre estudiante");
            nameS = Console.ReadLine();

            Console.WriteLine("apellido estudiante");
            lastS = Console.ReadLine();

            Console.WriteLine("email estudiante");
            emailS = Console.ReadLine();

            Console.WriteLine("Nombre facultad estudiante");
            facu = Console.ReadLine();

            Console.WriteLine("codigo facultad estudiante");
            codi = Convert.ToInt16(Console.ReadLine());

            ClsStudent student = new ClsStudent(nameS, lastS, emailS, codi, facu);

            Console.WriteLine(persona.toString());

            Console.WriteLine(student.toString());

        }
    }
}
