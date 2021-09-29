using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEmpleados
{
    public class ClsEmployees
    {
        private string _Name;
        private string _Lastname;
        private int _SueldoDiario;
        private int _Age;
        private int _LaboralDays;

        public ClsEmployees(string Nombre, string Apellido, int Sueldo, int Edad, int Dias )
        {
            Name = Nombre;
            Lastname = Apellido;
            SueldoDiario = Sueldo;
            Age = Edad;
            LaboralDays = Dias;
        }

        public string Name { get => _Name; set => _Name = value; }
        public string Lastname { get => _Lastname; set => _Lastname = value; }
        public int SueldoDiario { get => _SueldoDiario; set => _SueldoDiario = value; }
        public int Age { get => _Age; set => _Age = value; }
        public int LaboralDays { get => _LaboralDays; set => _LaboralDays = value; }

        public string SueldoTotal()
        {

            int sueldoTotal;

            sueldoTotal = LaboralDays * SueldoDiario;
            
            return $" \n El sueldo total es {sueldoTotal} derivado por: \n  Dias Trabajados:   {LaboralDays} \n  Sueldo Diario: {SueldoDiario}";
        }

        public string toString()
        {
            return $"Datos Almacenados: \n \n Nombre: {Name} \n Apellido: {Lastname} \n Edad: {Age} \n  \n \n Sueldo devengado {SueldoTotal()}";
        }
    }
}
