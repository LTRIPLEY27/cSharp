using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasComunicacion
{
    class ClsRectangulo
    {
        private double _Base;
        private double _Altura;

        public ClsRectangulo(int bas, int altura )
        {
            Base = bas;
            Altura = altura;
        }

        public double Base { get => _Base; set => _Base = value; }
        public double Altura { get => _Altura; set => _Altura = value; }

        public string CalculaArea()
        {
            double area;
            
            area = Base * Altura;

            return $"El area del rectangulo es: {area}";
        }

        public string toString()
        {
            return CalculaArea();
        }
    }
}
