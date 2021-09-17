using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEncapsulamiento
{
    class ClsPersona
    {
        private string _name;
        private int _age;
        private string _dni;
        private char _sex;
        private float _weigth;
        private float _heigth;

        public ClsPersona(string N, int A, string D, char S, float W, float H)
        {
            Name = N;  /// CON EL CONSTRUCTOR AUTOMATICO DE CSHARP SE HA DE SEGUIR ESTA SINTAXIS EN EL CONSTRUCTOR Y EN CUALQUIER ASPECTO DE LA CLASE!!!
            Age = A;
            Dni = D;
            Sex = S;
            Weigth = W;
            Heigth = H;

        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public char Sex { get => _sex; set => _sex = value; }
        public float Weigth { get => _weigth; set => _weigth = value; }
        public float Heigth { get => _heigth; set => _heigth = value; }

        public string CalcularMC()
        {
            string value;
            if((Weigth / (Heigth * Heigth)) < 20)
            {
                value = "Estas en tu peso ideal";
                //return = "Estas en tu peso ideal";
            }
            if ((Weigth / (Heigth * Heigth)) > 20 && (Weigth / (Heigth * Heigth)) <= 25)
            {
                //return "Es un peso correcto";
                value = "Es un peso correcto";
            } else
            {
               value = "Tienes sobrepeso";
            }

            return value;
        }

        public string EsMayorDeEdad()
        {
            string response = "";
            if(Age >= 18)
            {
                response = "Es mayor de edad";
                // return "Es mayor de edad";
            } else 
            {
                //return "Es menor de edad";
                response = "Es menor de edad";
            }

            return response;
        }

        public string toString()
        {
            return $"Ficha Tecnica \n  Nombre : {Name} \n Edad: {Age}  {EsMayorDeEdad()} \n DNI: {Dni} \n Sexo: {Sex} \n Peso: {Weigth} \n Altura: {Heigth} \n \n El Indice de Masa Corporal segun su valoracion es : {CalcularMC()}";
        }
    }
}
