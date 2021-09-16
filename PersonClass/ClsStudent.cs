using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class ClsStudent
    {
        public string name;
        public string email;
        public string lastname;
        public int code;
        public string FacuName;


        public ClsStudent(string nom, string correo, string cognom, int codi, string facu)
        {
            this.name = nom;
            this.email = correo;
            this.lastname = cognom;
            this.code = codi;
            this.FacuName = facu;
        }

        public string toString()
        {
            return $"Los datos almacenados en la base de datos sobre el estudiante son \n nombre: {this.name} \n apellido: {this.lastname} \n email: {this.email} \n Facultad: {this.FacuName} \n codigo: {this.code}  ";
        }
    }
}
