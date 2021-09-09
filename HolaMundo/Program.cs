using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)// METODO ESTATICO NO NECESITA A LA INSTANCIA PARA SER LLAMADO
        {

            Console.WriteLine("hello world");
            Console.WriteLine("touch a word, please");

            int i = 0;
            byte x = 255; // max valor 255
            char letter = 'c';
            decimal deci = 0.87845m; //m o M se deben de agregar al final
            float f = 0.55452f;// f o F al final
            double d = 0.586d; // d o D
            string cad = "hello";
            bool sem = false;
            DateTime date = DateTime.Today;

            dynamic vari = 23; // no recomendable, valora en tiempo la ejecucion de un dato.

            // salida cadena, letra y var

            //ENUMERAMOS LOS PARAMETROS SEGUN LOS IREMOS A INSERTAR, DE ESTA FORMA 
            Console.WriteLine("la salida de letre es {0}, letra {1} y dinamic {2}", cad, letter, vari);
            Console.WriteLine("el valor es i  {0} y dato es : {1}", i, x);

            Console.WriteLine("el valor de f es {0:F3}", f); //RESPECTO AL F SE DEBE DE ESPECIFICAR LA CANTIDAD DE DECIMALES QUE DESEEMOS

            // concatenar

            Console.WriteLine("el valor de semafalos es : " + sem.ToString());

            Console.WriteLine("la fecha es: " + date.ToShortDateString());

            Console.WriteLine(date);




            int a = 24;
            float z;
            z = a; // conversion de datos implicita

            Console.WriteLine("el valor de a es : {0:f2}", a);

            Console.WriteLine($"el valor es {a:f2}"); // ES IGUAL A LA OTRA FORMA DE ADMITIR DECIMALES

            int r = 45;

            double t;

            t = (double)r;  // CAST DE UN VALOR A OTRO

            Console.WriteLine($"el valor es {t:f2}");

            float dato = 12.29f;

            r = (int)dato;

            Console.WriteLine($"el valor es {r}");

            string cadena = string.Empty; // CADENA VACIA

            bool semaforo = false;

            r = Convert.ToInt32(semaforo);

            Console.WriteLine(r);

            cadena += "helium";

            Console.WriteLine(cadena);

            string cadena2 = "12345";

            r = Convert.ToInt32(cadena2);

            Console.WriteLine($"valor es {r}");

            
            Console.ReadKey();  // LEE UNA TECLA PARA ASEGURAR LA OBSERVACION DEL CODIGO

        }
    }
}
