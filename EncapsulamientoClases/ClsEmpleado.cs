using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamientoClases
{
    class ClsEmpleado
    {
        //PROPIEDADES
        private string _Nombre;//ENCAPSULAR
        private int _Edad;
        private float _SueldoDiario;

        public string Nombre {  // FORMA ABREVIADA DEL GETTER Y SETTER
            
            get => _Nombre; 
            set => _Nombre = value; 
        }
        public int Edad { get => _Edad; set => _Edad = value; }
        public float SueldoDiario { get => _SueldoDiario; set => _SueldoDiario = value; }

        //CONSTRUCTOR

        public ClsEmpleado(string N, int E, float S)
        {
            this._Nombre = N;
            this.Edad = E;
            this.SueldoDiario = S;
        }

        public float CalculaSueldo(int NumDias)
        {
            //return this._SueldoDiario * NumDias;  // REFIERE A LA PROPIEDAD
            //return _SueldoDiario * NumDias;// REFIERE A LA PROPIEDAD
            return SueldoDiario * NumDias; // EL GET QUE RETORNA LA PROPIEDAD
        }

    }

    

}
