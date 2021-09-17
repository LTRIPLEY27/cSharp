using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRectangulo
{
    class ClsRectangulo
    {
        public int lado1;
        public int lado2;

        public ClsRectangulo()
        {
            this.lado1 = 0;
            this.lado2 = 0;
        }

        public ClsRectangulo(int l1, int l2)
        {
            this.lado1 = l1;
            this.lado2 = l2;
        }

        public int CalculaArea()
        {
            return this.lado1 * this.lado2;
        }

        public int CalculaPerimetro()
        {
            return 2 * (this.lado1 + this.lado2);
        }
    }

}
