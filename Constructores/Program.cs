using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj1 = new Car(); // INSTANCIACION DE LA CLASE COCHE 
            Car coche = new Car();

            Car obj2 = new Car(4500.25, 1200.35);//AL RECIBIR PARAMETROS, SE ESTA LLAMANDO AL SEGUNDO CONSTRUCTOR Y ES AUTOMATICO COMO LO ENTIENDE.

            Console.WriteLine(obj2.getInfoCoche());


            Console.WriteLine(coche.getRuedas());

            Console.WriteLine(coche.getInfoCoche());
        }
    }

    class Car // DECLARACION DE LA CLASE
    {
        private string color;
        private int ruedas;
        private double largo;
        private double ancho;
        private bool clima;
        private string tapiceria;

        public Car() // CONSTRUCTOR
        {
            this.color = "red";
            this.ruedas = 4;
            this.largo = 2300.5;
            this.ancho = 0.800;
        }

        public Car(double largeCar, double anchCar) {

            this.ruedas = 4;
            this.largo = largeCar;
            this.ancho = anchCar;
            
        }           

        public int getRuedas()
        {
            return this.ruedas;
        } 

        public string getColor()
        {
            return this.color;
        }

        public string getInfoCoche()
        {
            return $"La informacion del coche es: \n {ruedas} \n color: {color} \n dimesiones {largo} \n {ancho}";
        }

    }
}
