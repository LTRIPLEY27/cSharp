using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int value1, value2;
            string entry;
            Console.WriteLine("introduzca un numero");
            entry = Console.ReadLine();  // ANALOGO AL "SYSTEM.IN" DE JAVA
            value1 = Convert.ToInt32(entry);

            Console.WriteLine("introduzca un numero");
            value2 = Convert.ToInt32(Console.ReadLine());  // ANALOGO AL "SYSTEM.IN" DE JAVA + CONVERSION DIRECTA
           if((value1 + value2) > 10)
            {
                Console.WriteLine("La suma es mayor que 10");
            } else
            {
                Console.WriteLine("la suma es menor a 10 ");
            }


            /// PERMITIMOS ENTRADA AL USUARIO : pepi con contraseña: 1234

            string user, pass;

            Console.WriteLine("introduzca su usuario");
            user = Console.ReadLine();

            Console.WriteLine("introduzca su password");
            pass = Console.ReadLine();

            if(user == "pepi" && pass == "1234")
            {
                Console.WriteLine("Bienvenido");
            } else
            {
                Console.WriteLine("datos incorrectos");
            }

            
            Donat el programa que realitzava el càlcul de la nota de la prova objectiva((aciertos-(errores / 3))*10) / 20 afegir el codi necessari per a que aparegui un missatge conforme estic aprovat o suspès, conjuntament amb la nota numèrica.


            //////////   VERSION NOTAS   ///////////////
            ///
            double note = 0,cont = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"ingrese la nota {cont + 1}");
                note += double.Parse(Console.ReadLine());
                cont++;
            }

            note /= 3 ;

            if(note >= 5.5 )
            { 
                Console.WriteLine($"Aproved, your range was {note:f2}");
            } else
            {
                Console.WriteLine($"Reproved, your range was {note:f2}");
            }
            

            float error, aciertos, nota;

            Console.WriteLine("indique la cantidad de aciertos");
            aciertos = float.Parse(Console.ReadLine());

            Console.WriteLine("indique la cantidad de errores");
            error = float.Parse(Console.ReadLine());

            //error *= 0.33f;

            //nota = (aciertos - error / 3.0f * 10.0f) / 20.0f;

            nota = (((float)aciertos - ((float)error / 3.0f)) * 10.0f) / 20.0f;

            if(nota > 5)
            {
                Console.WriteLine($"aprobado, la nota es {nota}");
            } else
            {
                Console.WriteLine($"reprobado. su nota es {nota}");
            }

            /////////////////////////////////////77

            Fer el codi necessari per tenir la entrada de dues dades(senceres) , es demana quina operación es vol; la suma, la resta, la divisió i la mutiplicació, i es dóna el resultat de l’operació.*/

            int num1, num2, sum = 0, rest = 0, mul = 0, div = 0;

            char operacion;
            string resp = "";

            /*   OPCION   DO WHILE

              do
              {

                  Console.WriteLine("indique el primer elemento");
                  num1 = int.Parse(Console.ReadLine());

                  Console.WriteLine("indique el segundo elemento");
                  num2 = int.Parse(Console.ReadLine());

                  Console.WriteLine("desea realizar alguna operacion, indique s para (suma), r para (resta), m para (multiplicacion) y d para (dividir)? ");

                  operacion = Convert.ToChar(Console.ReadLine());

                  switch(operacion)
                  {
                      case 's':
                          Console.WriteLine($"La suma es igual a  {num1 + num2}");
                          break;
                      case 'r':
                          Console.WriteLine($"La resta es igual a  {num1 - num2}");
                          break;
                      case 'm':
                          Console.WriteLine($"La multiplicacion es igual a  {num1 * num2}");
                          break;
                      case 'd':
                          Console.WriteLine($"La division es igual a  {num1 / num2}");
                          break;
                      default:
                          Console.WriteLine("debe de ingresar una opcion valida");
                          break;
                  }

              } while (num1 > 0 && num2 > 0); cw        

            Console.WriteLine("desea ingresar al programa?");
            resp = Console.ReadLine();

            Console.WriteLine("indique el primer elemento");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("indique el segundo elemento");
            num2 = int.Parse(Console.ReadLine());


            

            while(num1 > 0 && num2 > 0 && resp == "si") {

                Console.WriteLine("cual operacion desea realiza, indique s para (suma), r para (resta), m para (multiplicacion) y d para (dividir)? ");

                operacion = Convert.ToChar(Console.ReadLine());

                switch (operacion)
            {
                case 's':
                    Console.WriteLine($"La suma es igual a  {num1 + num2}");
                    break;
                case 'r':
                    Console.WriteLine($"La resta es igual a  {num1 - num2}");
                    break;
                case 'm':
                    Console.WriteLine($"La multiplicacion es igual a  {num1 * num2}");
                    break;
                case 'd':
                    Console.WriteLine($"La division es igual a  {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("debe de ingresar una opcion valida");
                    break;
            }

                Console.WriteLine("desea continuar?");
                resp = Console.ReadLine();
         

                Console.WriteLine("indique el primer elemento");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("indique el segundo elemento");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("desea realizar alguna operacion, indique s para (suma), r para (resta), m para (multiplicacion) y d para (dividir)? ");
            }
            
             
            //////////   OTRO  EJERCICIO ///////////////

             Fer el codi necessari per entrar un número i intentar endevinar un número aleatori generat pel programa.
             
             */

            int num, cont = 0;
            Random ran = new Random();  // OBJETO DE LA CLASE RANDOM PARA CREAR EL NUMERO AL AZAR

            int random = ran.Next(1, 101);  // PARAMETROS ENTRE LOS CUALES SE CREARA EL NUMERO EN UNA VARIABLE QUE LO ALMACENE

            Console.WriteLine("Prueba tu suerte");
            Console.WriteLine("ingresa un  numero del 1 al 100");
            num = int.Parse(Console.ReadLine());

            while (cont < 2 && num > 0) { 
                if(num == random)
                {
                    Console.WriteLine("Eres AFORTUNADO");
                } else
                {

                    Console.WriteLine($"continua intentando, solo dispones de 3 oportunidades, tienes {cont} de ellos");
                    cont++;

                }

                Console.WriteLine("Prueba tu suerte");
                Console.WriteLine("ingresa un  numero del 1 al 100");
                num = int.Parse(Console.ReadLine());

            }


            Console.ReadKey();
        }
    }
}
