using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class ClsPerson
    {
        private string _Name;
        private string _Dni;
        private int _Age;

        public ClsPerson(string Nombre, string DNI, int Edad)
        {
            Name = Nombre;
            Dni = DNI;
            Age = Edad;
        }

        public string Name { get => _Name; set => _Name = value; }
        public string Dni { get => _Dni; set => _Dni = value; }
        public int Age { get => _Age; set => _Age = value; }

        public string toString()
        {
            return $"El registro del usuario es: \n \n Nombre {Name} \n Dni {Dni} \n Edad {Age}";
        }
    }

    
}
