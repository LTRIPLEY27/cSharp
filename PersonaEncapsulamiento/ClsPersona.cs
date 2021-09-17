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

        public string calcularMC()
        {
            if(Weigth / Heigth < 20)
            {
                return "Estas en tu peso ideal";
            }
            if (Weigth / Heigth > 20 && Weigth / Heigth <= 25)
            {
                return "Es un peso correcto";
            } else
            {
                return "Tienes sobrepeso";
            }
        }

        public string esMayorDeEdad()
        {
            if(Age >= 18)
            {
                return "Es mayor de edad";
            } else 
            {
                return "Es menor de edad";
            }
        }

        public string toString()
        {
            return $"Ficha Tecnica \n  Nombre : {Name} \n Edad: {Age}  {esMayorDeEdad()} \n DNI: {Dni} \n Sexo: {Sex} \n Peso: {Weigth} \n Altura: {Heigth} \n \n El Indice de Masa Corporal segun su valoracion es : {calcularMC()}";
        }
    }
}
