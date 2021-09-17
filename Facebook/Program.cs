using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro Nuevo usuario Facebook");

            Console.WriteLine("Nombre: ");
            string nom = Console.ReadLine();


            Console.WriteLine("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Contraseña: ");
            string pass = Console.ReadLine();

            ClsFacebook libro = new ClsFacebook(nom, edad, pass);

            Console.WriteLine(libro.toString());



        }
    }
}
