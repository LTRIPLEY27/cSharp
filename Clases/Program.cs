using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program // LAS CLASES SI DEBEN DE ESTAR COMPRENDIDAS DENTRO DEL NAMESPACE
    {
        static void Main(string[] args)
        {
            /* DateTime timer = new DateTime();

             timer = DateTime.UtcNow;

             Console.WriteLine($"Este instante : {timer}");*/


            // LA CALCULADORA TIENE UN ANCHO DE 15
            // LA CALCULADORA LA ABRIMOS Y CERRAMOS CON METODOS
            Ventana venti = new Ventana();

            Console.WriteLine($"L ventana tiene unas dimensiones, ancho {venti.ancho} y alto : {venti.alto}");

            venti.Maximizar();
            venti.Cerrar();

            Console.ReadKey();
        }

    }

    class Ventana // CLASE EXTERNA A LA PROGRAM
    {
        public int ancho = 15;// propiedades
        public int alto = 20;
        public string color = "yellow";
        /*public : cualquier clase puede acceder
         * private: desde dentro de la propia clase.
         * protected : solo se puede acceder desde las clases hijas(derivadas).
         * static : no necesita instancia de la clase
         */

        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro-...");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se abrio...");
        }
     }
}
