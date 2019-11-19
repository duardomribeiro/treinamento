using MinhaPrimeiraAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.DAL
{
    
    
        public interface IProdutoRepository
        {
            void Adicionar(Produto produto);
            void Apagar(Produto produto);
            void Editar(Produto produto);
            Produto Obter(int id);
            IEnumerable<Produto> Obter();
        }
    
}
