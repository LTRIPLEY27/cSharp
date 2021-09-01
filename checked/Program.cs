using System;

namespace UsoChecked{
    class Program
{
    static void Main(string[] args)
    {
            
                int num = int.MaxValue; // EL METODO "MaxValue" REFIERE AL NUMERO MAXIMO DE UN PRIMITIVO INT

            //int result = checked(num + 20); // FORMA ABREVIADA DEL CHECKED PARA VERIFICAR UNA COMPROBACION ESPECIFICA

                int result = unchecked(num + 15); // ANVERSO DEL CHECKED
                Console.WriteLine(result);
           
            
    }
}
}
