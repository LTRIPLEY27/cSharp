using System;

namespace Methods
{
    class Program
    {
        int numero1 = 5;
        int numero2 = 9;
        static void Main(string[] args)
        {
            mensajeEnPantalla();

            Console.WriteLine("from Main");

            Console.WriteLine("introduce el numero 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce el numero 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(sumaNumeros(num1, num2)); //LLAMADO AL METODO CON RETURN 
            Console.WriteLine($"la division de los numeros es igual a {divideNumber(num1,num2)}");


            Console.WriteLine("introduce la letra ");
            string a = Console.ReadLine();

            Console.WriteLine("introduce la letra ");
            string b = Console.ReadLine();

            Console.WriteLine($"la suma de letras es {gimeName(a,b)}");

            int b1 = 7;
            double b2 = 5.2;
            double b3 = 8.3;

            Console.WriteLine(Resta(b1, b2, b3));
        }
                                                                    // PARA CONVERTIR UN PARAMETRO A OPCIONAL, SE LE DEBE DE INDICAR UN VALOR EN LA ZONA DE PARAMETROS
        private static double Resta(int nume1, double nume2, double nume3 = 0)
        {
            return NewMethod(nume1, nume2, nume3); // SE PUEDEN RETORNAR METODOS CONCATENADOS
        }


        private static double NewMethod(int nume1, double nume2, double nume3 = 0) // EL METODO ES LLAMADO DESDE EL RETURN ANTERIOR, INCLUIDO LOS PARAMETROS
        {
            return (nume1 - nume2) + nume3;
        }

        // FORMA ABREVIADA 

        // private static double Resta(int v1, double v2) => v1 - v2;

        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo csharp");
        }

        static int sumaNumeros(int num1, int num2)
        {
            //Console.WriteLine($"la suma de los numeros es { num1 + num2}");

            return num1 + num2;
        }

        static double divideNumber(int num1, int num2) => num1 / num2; // EN C# LA NOMENCLATURA CON LA FLECHA FUNCIONA PARA METODOS QUE SOLO TENGAN UNA LINEA DE EJECUCION PARA SIMPLIFICAR.

        static int suma(int op1, int op2) => op1 * op2;

        static string gimeName(string a, string b) => a + b;

        void segundoMetodo()
        {
            Console.WriteLine(numero1 * numero2);
        }
    
    }
}
