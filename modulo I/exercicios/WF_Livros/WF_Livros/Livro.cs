using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Livros
{
    public class Livro
    {


        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public int NumeroPaginas { get; private set; }
    }
}
