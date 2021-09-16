using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsFiguras
{
    class ClsTriangulo
    {
        /*Propiedades dos: base y altura
         constructores:
        1. inicializa base y altura
        2. inicialica base y altura vale 5
        3. inicializa altura y base vale 4
        
         metodo CalculaArea()*/

        public int baseTri;
        public int altura;

        public ClsTriangulo(int baseT, int alt)  // 1. inicializa base y altura
        {
            this.baseTri = baseT;
            this.altura = alt;
        }

        public ClsTriangulo(int alt) //2. inicialica base y altura vale 5
        {
            this.baseTri = 0;
            this.altura = alt;
        }

       /* public ClsTriangulo(int alt, int baseT){

            this.altura = alt;
            this.baseTri = baseT;

        }// 3. inicializa altura y base vale 4*/
       

        public double CalculaArea() //metodo CalculaArea()
        {
            return ((double)this.baseTri * (double)this.altura) / 2.0f;
        }
    }
}
