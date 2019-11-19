using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Model;

namespace MinhaPrimeiraAPI.DAL
{
    public class ProdutoRepository : IProdutoRepository
    {
        public readonly Contexto _context;

        public ProdutoRepository(Contexto context)
        {
            _context = context;
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Apagar(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public void Editar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Produto Obter(int id)
        {
            return _context.Produtos.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<Produto> Obter()
        {
            return _context.Produtos.ToList();
        }
    }
}
