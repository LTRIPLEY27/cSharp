using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasForms
{
    class ClsTriangulo
    {
        private double _Base;
        private double _Altura;


        public ClsTriangulo (double B, double A)
        {
            Base = B;
            Altura = A;
        }

        public double Base { get => _Base; set => _Base = value; }
        public double Altura { get => _Altura; set => _Altura = value; }

        public double getArea()
        {
            double area;

            area = (Base * Altura) / 2;

            return area;
        }

        public string toString()
        {
            return $"El area del triangulo es igual a: {getArea()}"; //Math.Round(getArea()), 2
        }
    }
}
