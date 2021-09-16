using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsFiguras
{
    class ClsCirculo
    {
        public int radio; // PROPIEDAD

        public ClsCirculo()
        {
            this.radio = 0;
        }

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
    }
}
