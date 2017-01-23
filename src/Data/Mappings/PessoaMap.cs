using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Mappings
{
    public class PessoaMap
    {
        
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(config =>
            {
                config.ToTable("Pessoa");
                config.HasKey(x => x.Id);

                config.Property(x => x.Nome)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("Nome")
                    .IsRequired();
            });
        }
        
    }
}
