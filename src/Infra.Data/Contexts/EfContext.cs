using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Contexts
{
    public class EfContext: DbContext
    {
        public EfContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"Data Source=VARCALSYS\MSSQLSERVER2016;Initial Catalog=AspNetCoreDDD;Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(config =>
            {
                config.ToTable("Pessoa");
                config.HasKey(p => p.Id);
                config.Property(p => p.Nome)
                    .HasColumnName("Nome")
                    .HasMaxLength(100)
                    .IsRequired();
                config.Property(p => p.DataCadastro)
                    .IsRequired();
                config.Property(p => p.Ativo)
                    .IsRequired();
            });


        }
    }
}
