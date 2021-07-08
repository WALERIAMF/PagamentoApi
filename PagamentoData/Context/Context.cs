using DetalhesPagamento.Mapping;
using Microsoft.EntityFrameworkCore;
using PagamentoDomain.Model;
using System;
using System.Linq;

namespace PagamentoData.Context
{

    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<DetalhesPagamentoModel> DetalhesPagamento { get; set; }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DetalhesPagamentoMap());

        }
    }
}
