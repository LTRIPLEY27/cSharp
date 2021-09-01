using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.IO.StreamReader archivo = null;  // CANAL DE LECTURA (CONSUMO DE RECURSOS) POR ENDE ES NECESARIO CERRARLO

            try
            {

                string linea;
                int cont = 0;

                string path = @"C:\Users\hellz\source\repos\LTRIPLEY27\cSharp\CsharpManuaL.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea = archivo.ReadLine()) != null ) {  // CONDICIONAL = "MIENTRAS EL ARCHIVO SEA NULO"
                    Console.WriteLine(linea); // IMPRIME EL ARCHIVO

                    cont++;
                }
            
            } catch(Exception e)
            {
                Console.WriteLine("sorry");
            } 
            finally // IMPERATIVO PARA EVITAR EL USO DE RECURSOS INNECESARIOS ADHERIR EL FINALLY
            {
                if (archivo != null) archivo.Close();

                Console.WriteLine("conexion cerrada");
            }
        }
    }
}
