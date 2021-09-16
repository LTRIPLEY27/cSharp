using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class ClsPerson
    {
        public string nom;// ATRIBUTOS
        public string cognom;
        public string email;

        // CONSTRUCTOR PERSON
        public ClsPerson(string name, string lastname, string ema)
        {
            this.nom = name;
            this.cognom = lastname;
            this.email = ema;

        }

        public string toString()
        {
            return $"Los datos almacenados en la base de datos sobre su persona son \n nombre: {this.nom} \n apellido: {this.cognom} \n email: {this.email}  ";
        }
    }
}
