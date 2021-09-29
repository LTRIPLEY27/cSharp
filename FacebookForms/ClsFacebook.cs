using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookForms
{
    class ClsFacebook
    {
        //nom, edat i password
private string _Nombre;
        private int _Edad;
        private string _Pass;
        // get set
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
        public string Pass { get => _Pass; set => _Pass = value; }



        // constructor de 3
        public ClsFacebook(string n, int e, string p)
        {
            Nombre = n;
            Edad = e;
            Pass = p;
        }

        // método VerInfo
        public string VerInfo()
        {
            return "Bienvenid@" + Nombre + " con edad: " + Edad + " tiene el password:" + Pass;
        }



    }

}

