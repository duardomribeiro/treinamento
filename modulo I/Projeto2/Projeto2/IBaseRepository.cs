using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public interface IBaseRepository<T>
    {
        T Inserir(Conta conta);
        T Editar(Conta conta);
        T Apagar(int id);
        T Obter(int id);
        IEnumerable<T> Obter();
        

    }

}
