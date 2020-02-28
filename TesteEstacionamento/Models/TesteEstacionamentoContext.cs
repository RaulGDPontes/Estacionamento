using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEstacionamento.Models
{

    public class TesteEstacionamentoContext : DbContext
    {
        public TesteEstacionamentoContext(DbContextOptions<TesteEstacionamentoContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValorModel>().ToTable("Valores");
            modelBuilder.Entity<ClienteModel>().ToTable("Clientes");
        }

        public DbSet<ValorModel> Valores { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
