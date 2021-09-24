using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseLibros
{
    class ClsLibros
    {

        private string _Title;
        private string _Author;
        private int _Examples;
     

        public ClsLibros(string Titulo, string Autor, int Ejemplar)
        {
            Title = Titulo;
            Author = Autor;
            Examples = Ejemplar;
        }

        

        public string Title { get => _Title; set => _Title = value; }

        public string Author { get => _Author; set => _Author = value; }

        public int Examples { get => _Examples; set => _Examples = value; }

        public string toString()
        {
            return $"El libro almacenado tiene los siguientes datos: \n \n Titulo: {Title} \n Autor: {Author} \n Ejemplar : {Examples}";
        }
    }
}
