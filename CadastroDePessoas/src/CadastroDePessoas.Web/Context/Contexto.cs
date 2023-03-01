using CadastroDePessoas.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoas.Web.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }

    }
}
