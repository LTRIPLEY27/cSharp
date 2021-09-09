using System;

namespace Objetcs
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle newCircle = new Circle(); // CREACION DE OBJETO E INICIACION DE LA CLASE


            Console.WriteLine("hello stranger, indique el radio");
            int radio = int.Parse(Console.ReadLine());

            newCircle.CalculaArea(radio);

            //Console.WriteLine(newCircle.pi); SI NO ES ACCESIBLE NO SE MODIFICA, POR ENDE SE DECLARA COMO CONSTANTE
            
            Console.WriteLine($"El area es igual a {newCircle.CalculaArea(radio)}");

            Converssor obj1 = new Converssor();

            obj1.CambiaValor(1.37);

            Console.WriteLine(obj1.Convertir(55));

            Console.ReadKey();
        }
    }

    // PRIMERA CLASE CREADA EN CSHARP (SIEMPRE DENTRO DEL NAMESPACE)
    class Circle
    {

        const double pi = 3.1416; // PROPIEDAD CLASE CIRCULO

        
        public double CalculaArea(int radio) // METODO DE CLASE
        {
            return pi * radio * radio;
        }

    }

    class Converssor
    {
        private double euro = 1.23;

        public double Convertir(double cant)
        {
            return cant * euro;
        }


        public void CambiaValor(double nuevo)
        {
            if(nuevo < 0) 
            {
                euro = 1.23;

            }else
            {
                euro = nuevo;
            }

            
                
        }

    }

}
