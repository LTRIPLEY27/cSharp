using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class ClsFacebook
    {
        private string _Name;
        private int _Age;
        private string _Password;

        public ClsFacebook(string N, int A, string P)
        {
            this.Name = N;
            this.Age = A;
            this._Password = P;
        }

        public string Name { get => _Name; set => _Name = value; }
        
        public int Age { get => _Age; set => _Age = value; }
        
        
        public string Password { get => _Password; set => _Password = value; }

        public string toString()
        {
            return "Los datos registrados en su perfil de Facebook son \n Nombre: " + _Name + "\n Edad: " + this._Age + "\n Contraseña: " + Password;
        }
    }
}
