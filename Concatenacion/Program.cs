using System;

namespace Concatenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 19;
            //LA INTERPOLACION ES UNICA A C# PARA CONCATENAR, SE IMPLEMENTA
            // INSERTANDO EL SIGNO "$" ANTES DE LAS COMILLAS Y LLAMANDO A LA VARIABLE DENTRO DE LLAVES.

            Console.WriteLine($"Tu edad es igual a : {edad}"); // ES LA MANERA DE IMPLEMENTAR LA INTERPOLACION
        }
    }
}
