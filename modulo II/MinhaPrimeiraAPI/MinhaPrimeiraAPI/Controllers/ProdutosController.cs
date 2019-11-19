using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Model;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public readonly IProdutoRepository _produtorepository;

        public ProdutosController(IProdutoRepository ProdutoRepository)
        {
            _produtorepository = ProdutoRepository;
        }

        [HttpPost]
        public void Adicionar(Produto produto)
        {
            _produtorepository.Adicionar(produto);
        }
        
        [HttpPut]
        public void Editar(Produto produto)
        {
            _produtorepository.Editar(produto);
        }
        
        [HttpDelete("{id}")]
        public void Apagar(int id)
        {
            var produto = _produtorepository.Obter(id);
            _produtorepository.Apagar(produto);
        }
        
        [HttpGet("{id}")]
        public void Obter(int id)
        {
            _produtorepository.Obter(id);
        }
        
        [HttpGet]
        public IEnumerable<Produto>Obter()
        {
            return _produtorepository.Obter();
        }
    }
}