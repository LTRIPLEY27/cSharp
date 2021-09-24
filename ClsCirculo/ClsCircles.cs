using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCirculo
{
    class ClsCircles  // LA CLASE CIRCLES AL COMPARTIR EL "NAMESPACE" CON JAVA NO HACE NECESARIA EL LLAMADO SINO SOLO INSTANCIARLA Y LA RECONOCERA.
    {

        public int radio; // PROPIEDAD

        /*public ClsCircles(float v)
        {
            this.radio = v;
        }*/

        public ClsCircles(int ra)
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

