using System;

namespace Concatenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //        int edad = 19;
            //LA INTERPOLACION ES UNICA A C# PARA CONCATENAR, SE IMPLEMENTA
            // INSERTANDO EL SIGNO "$" ANTES DE LAS COMILLAS Y LLAMANDO A LA VARIABLE DENTRO DE LLAVES.

            //      Console.WriteLine($"Tu edad es igual a : {edad}"); // ES LA MANERA DE IMPLEMENTAR LA INTERPOLACION


            ////////////////////////////

            int edadPersona1;
            int edadPersona2;

            edadPersona1 = edadPersona2 = 33; //CONCATENACION DE VALORES EN MULTIPLES VARIABLES

            Console.WriteLine($"edad persona1 = {edadPersona1}");

            Console.WriteLine($"PERSONA2 {edadPersona2}");

            // DECLARACION IMPLICITA //
            /* CON LA PALABRA RESERVADA VAR, EL COMPILADOR ASIGNA EL TIPO DE VALOR DE LA VARIABLE, EL MISMO VALOR SE DEBE DE RESPETAR Y NO SE PUEDE REASIGNAR*/

            var edadPersona = 27;

            Console.WriteLine(edadPersona);

            // CONVERSIONES EXPLICITAS E IMPLICITAS (CASTING)//

            double temperature = 34.5;

            int temperaturaCat;
            // CON EL CAST () SE HACE LA CONVERSION EXPLICITA
            temperaturaCat =(int) temperature; // DICHA CONVERSION SE HACE CON UN CAST ANTEPONIENDO EN PARENTESIS EL VALOR QUE DESEAMOS CONVERTIR

            int habitantesCiudad = 1000;

            long habitantesReus = habitantesCiudad; // CONVERSION IMPLICITA
            Console.WriteLine(temperaturaCat);
            Console.WriteLine(habitantesReus);

            float pesoMaterial = 5.78F;//CON FLOAT SE LE DEBE DE ESPECIFICAR CON(F) EN MAYUSCULAS PARA QUE ACEPTE LA ASIGNACION
            double pesoMaterialPrec = pesoMaterial;

            Console.WriteLine(pesoMaterialPrec);

            //////// PARSE ////////////
            ///
            /*
            Console.WriteLine("introduce valor 1");

            Console.ReadLine(); // OBTIENE EL VALOR POR CONSOLA
            int aux1 = int.Parse(Console.ReadLine()); // CON EL PARSE CONVERTIMOS EL VALOR TEXTO EN NUMERICO
            Console.WriteLine("introduce valor 2");
            int aux2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es " + (aux1 + aux2));
            */

            ////////// CONSTANTES ///////////
            const int VALOR = 5; // LAS CONSTANTES SE HAN DE DEFINIR EN LA MISMA LINEA QUE SE INICIA
            // LAS CONSTANTES, PARA DIFERENCIARLAS DE LA VARIABLE, SE HAN DE ASIGNAR EN MAYUSCULAS

            const int VALOR2 = 9;
                                    //EL USO DE LAS CONSTANTES Y SUS VALORES SE HACEN
                                    //COMO EN PARAMETROS, LLAMANDO EL VALOR SEGUN SU INDEX, PARTIENDO DESDE 0
            Console.WriteLine("el valor de la constante es {0}" , VALOR, VALOR2); // EL USO DE LAS CONSTANTES SE PUEDE HACER MEDIANTE "," EN LA CONCATENACION

            const double PI = 3.1416;
            Console.WriteLine("introduce la medida");

            double radi = double.Parse(Console.ReadLine());

            // double area = radi * radi * PI;
            double area = Math.Pow(radi, 2)*PI; // EL METODO POW TOMA COMO ARGUMENTOS EL PARAMETRO * EL EXPONENTE AL QUE SE DESEA PROYECTAR
            Console.WriteLine($"el area del circulo es : {area}");
        }

    }
    
}
