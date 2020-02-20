using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sage.Pessoas.Domain;
using Sage.Pessoas.Infra.Data.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sage.Pessoas.Infra.Data
{
    public class PessoaContext : DbContext
    {
        public PessoaContext()
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
        
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

    }
}
