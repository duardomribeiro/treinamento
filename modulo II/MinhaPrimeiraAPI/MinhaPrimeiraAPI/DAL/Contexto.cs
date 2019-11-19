using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { 
        }

        public DbSet<Produto> Produtos { get; set; }
    
    }

}
