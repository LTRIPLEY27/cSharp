using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXCEPCIONES

            try
            {
                //codigo con potencial falla
                Console.WriteLine("introduzca la cantidad del producto");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("precio producto");
                double precio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"el precio total es {((double)cantidad*precio):F2}");
            }
            catch (Exception error)
            {// instrucciones para dicho caso

                Console.WriteLine("ocurrio un error " + error.Message);
            }

            int num1 = 3000;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1/num2);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Divion por 0!!!, Nobody cant");
                
            }

            //IndexOutof RangeException

            try
            {

                int[] arra = new int[4] { 1, 2, 3, 4};

                Console.WriteLine(arra[5]);

            } catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("La longitud es menor a la que demanda");
            }
            Console.ReadKey();

            try
            {

            }
            catch (Exception)
            {

                
            }
        }
    }
}
