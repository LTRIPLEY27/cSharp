using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetos
{
    class ClsEmpleados // CLASE EMPLEADOS EN OTRA PESTAÑA (MODULARIZACION)
    {
        public string Nombre;
        public float SueldoDiario;
        public int Edad;
        
        
        public ClsEmpleados(string n, float s, int e) // CONSTRUCTOR
        {
            this.Nombre = n;
            this.SueldoDiario = s;
            this.Edad = e;
        }

        // SOBRECARGA DE CONSTRUCTORES
        public ClsEmpleados()
        {
            this.Nombre = "";
            this.SueldoDiario = 0.0f;
        }
        // CONSTRUCTOR QUE RECIBE 2 PARAMETROS ADOPTA AL QUE RECOGE 3 PARAMETROS Y LE INDICA LOS MISMOS VALORES 
        public ClsEmpleados(string n, int e) : this(n, 850.0f, e) { }  // CONSTRUCTOR STATIC ****  LLAMA A OTRO CONSTRUCTOR 

        public float CalculaSueldo(int NumDias)
        {
            return SueldoDiario *= NumDias;
        }

    }
}
