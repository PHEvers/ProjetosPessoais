using CadastroDePessoas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoas.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
