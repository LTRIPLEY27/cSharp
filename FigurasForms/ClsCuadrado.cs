using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasForms
{
    class ClsCuadrado
    {
        private double _LabelA;
        private double _LabelB;

        public ClsCuadrado (double Lado1, double Lado2)
        {
            LabelA = Lado1;
            LabelB = Lado2;
        }

        public double LabelA { get => _LabelA; set => _LabelA = value; }
        public double LabelB { get => _LabelB; set => _LabelB = value; }

        public double getArea()
        {
            double area;

            area = LabelA * LabelB;

            return area;
        }

        public string toString()
        {
            return $"El area del triangulo es igual a: {getArea()}";
        }
    }


}
