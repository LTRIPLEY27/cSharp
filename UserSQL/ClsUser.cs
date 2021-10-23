using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSQL
{
    public class ClsUser// declaracion de clase publica para hacer uso de los metodos desde otras instancias
     {
        private string _Users;
        private string _Password;
        private string _Mail;

        public ClsUser(string user, string pass, string mail)
        {
            Users = user;
            Password = pass;
            Mail = mail;
        }

        public string Users { get => _Users; set => _Users = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
    }


}
