using System;

namespace LanzamientoThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique el mes a informar");
            int mes = int.Parse(Console.ReadLine());

            try
                {
                Console.WriteLine(NameMonth(mes));
            } catch (Exception e)
            {
                Console.WriteLine("numero incorrecto" + e.Message);
            }
            
        }

        public static string NameMonth(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "Octuber";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    // return "Inexistent Month";
                    throw new ArgumentOutOfRangeException();// CREACION DEL OBJETO DEL UMENT EXCEPTIONTIPO ARG
                //CON LA EXCEPCION "throw" SE OBLIGA A HACER USO DEL "try catch" EN LA LLAMADA DEL METODO
            }
        }

    }
}
