using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasEncapsulamiento
{
    class ClsTriangulo
    {
        private double _ladoA;
        private double _ladoB;


        public ClsTriangulo(double A, double B)
        {
            this._ladoA = A;
            _ladoB = B;
        }

        public double ladoA { get => ladoA; set => ladoA = value; }

        public void setLadoB(double B)
        {
            this._ladoB = B;
        }

        public double getLadoB()
        {
            return _ladoB;
        }

        public double CalculaArea()
        {
            return (_ladoA * _ladoB) / 2.0f;
        }
        public string toString()
        {
            return "El Area del triangulo es : " + CalculaArea();
        }
    }
}
