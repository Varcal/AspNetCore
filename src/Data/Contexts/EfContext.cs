using Data.Mappings;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class EfContext: DbContext
    {
        public EfContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string CONNECTIONSTRING = @"Data Source=VARCALSYS\MSSQLSERVER2014;Initial Catalog=AspNetCore;Integrated Security=True";
            optionsBuilder.UseSqlServer(CONNECTIONSTRING);
        }


        public DbSet<Pessoa> Pessoas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           PessoaMap.Configure(modelBuilder);
        }
    }
}
