﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Projeto2Context : DbContext
    {
        public Projeto2Context() : base("conexao")
        {            
        }        
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Banco> Bancos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ContaMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new BancoMap());

            modelBuilder.Entity<Conta>()
                .HasRequired<Cliente>(c => c.Cliente)
                .WithMany(a => a.Contas)
                .HasForeignKey<int>(c => c.ClienteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
