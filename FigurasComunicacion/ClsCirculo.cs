using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasComunicacion
{
    class ClsCirculo
    {
        public int radio; // PROPIEDAD

        /*public ClsCircles(float v)
        {
            this.radio = v;
        }*/

        public ClsCirculo(int ra)
        {
            this.radio = ra;
        }

        public double CalcularArea()
        {

            return this.radio * this.radio * Math.PI;

            // pi * (radio al cuadrado)
        }

        public double CalcularPerimetro()
        {
            return this.radio * 2 * Math.PI;
        }

        public string toString()
        {
            return $"El area del circulo es igual a: {CalcularArea()}";
        }
    }

}

