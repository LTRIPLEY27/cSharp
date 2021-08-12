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
        
        }
    }
    
}
