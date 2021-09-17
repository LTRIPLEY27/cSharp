using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasEncapsulamiento
{
    class ClsCirculo
    {
        private double _Radio;


        public ClsCirculo(double R)
        {
            Radio = R;
        }
        public double Radio { get => _Radio; set => _Radio = value; }

        public double CalculaArea()
        {

            return (_Radio * this._Radio
                 * Math.PI);

        }

        public string toString()
        {
            return "El area del circulo es " + CalculaArea();
        }
    }
}
