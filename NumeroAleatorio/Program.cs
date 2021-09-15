using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroAleatorio
{
    class Program
    {/*
Activitat 1:Fer un programa en el qual es demana si es vol o no jugar.En el cas de voler jugar:Esdemana el nom i esdemana quants intents es volen.Com a molt es deixa jugar 10 intents, s’ha de controlar que no posi més.A nivel intern es genera un número aleatori.Es van demanant números fins que no encerti o fins que es passi dels intents introduïts.Els números introduïts es desen en algún tipus de col·lecció,Si s’encerta abans del número màxim d’intents es felicita i es fa una sortida del tipus:“Felicitats Laura has encertat al tercer intent “Posar : tercer, quart,etc...Sinó “Laura t’has passat d’intents...teníem cinc intents...”i apareix la llista dels números introduïts.En el cas de no voler jugarapareix una sortida del tipus: “Laura..Un altre dia será...”Observació: Sense funcions 
*/
        static void Main(string[] args)
        {
            int num, aux, cont = 0, intents;
            Random num1 = new Random();
            int numAleatorio = num1.Next(0, 100);
            string respuesta = "";
            string name;
            bool acierto = false;
            Stack almacena = new Stack();

            Console.WriteLine("Desea probar su suerte?");
            respuesta = Console.ReadLine().ToLower();


            if (respuesta == "si")
            {
                Console.WriteLine("indica tu nombre");
                name = Console.ReadLine();

                do  /// RECORDAR LA CONDICION DE SER MENOR A 10
                {
                    Console.WriteLine("indique la cantidad de oportunidades con la que desea probarse");
                    intents = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numAleatorio);
                } while (intents > 10);
                
                    while(cont < intents && intents < 11)
                    {
                         Console.WriteLine($"indique su numero de la suerte, este es tu {cont + 1} intento??");
                         num = Convert.ToInt32(Console.ReadLine());
                         almacena.Push(num);
                         cont++;
                             if (num == numAleatorio)
                                {
                                    Console.WriteLine($"Felicitats {name} has encertat al {cont} intent");
                                    acierto = true;
                                    almacena.Push(num);
                                    break;
                                }
                             if (num != numAleatorio)
                                {
                                    Console.WriteLine($"indique su numero de la suerte, este es tu {cont + 1} intento?");
                                    num = Convert.ToInt32(Console.ReadLine());
                                    almacena.Push(num);
                                    cont++;
                                }

                    }

                if(!acierto)
                {
                    Console.WriteLine($"{name} t’has passat d’intents...teníem {intents} intents, los numeros que has introducido han sido:...");
                    foreach (var nume in almacena)
                    {
                        Console.WriteLine(nume); ;
                    }
                }
               

            } else
            {
                Console.WriteLine("Un altre dia será...");
            }


/*VERSION    DE SONIA     
         
          Stack miPila = new Stack();
            Console.WriteLine("Su nombre?");
            string nombre = Console.ReadLine();
            Console.WriteLine("Buenos días..Desea jugar? S o N..");
            string  respuesta = Console.ReadLine().ToLower();
            int intentos, num, aleatorio,tiradas=0;
            bool b = false;
            if (respuesta == "s")
            {
                do
                {
                    Console.WriteLine("Cuántos intentos??");
                    intentos = Convert.ToInt16(Console.ReadLine());
                }
                while (intentos > 10);

                Random r = new Random();
                aleatorio = r.Next(1,10);
                //Console.WriteLine("Num:"+aleatorio);
                for (int i = 1; i <= intentos; i++)
                {   
                    Console.WriteLine("Num?");
                    num= Convert.ToInt16(Console.ReadLine());
                    miPila.Push(num);
                    
                    tiradas++;
                    if (num == aleatorio) {
                        Console.WriteLine("Felicidades "+nombre+ " has acertado! en al tirada"+tiradas);
                        b= true;
                        break; }
                    
                 
                }
                if (!b) { Console.WriteLine("Lo sentimos.." + nombre + " Te has pasado de intentos.. los números introducidos son..:"); 
                    foreach( int numero in miPila)
                    {
                        Console.WriteLine(numero);
                    }   
                }
               Console.ReadKey(); 

            }

            else { Console.WriteLine("Querida/o {0} otro día será...",nombre); }
            Console.ReadKey();
         
         
         */
            
        }
    }
}
