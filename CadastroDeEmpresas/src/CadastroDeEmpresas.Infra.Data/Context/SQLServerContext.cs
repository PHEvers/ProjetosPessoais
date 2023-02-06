using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeEmpresas.Domain.Entities;

namespace CadastroDeEmpresas.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            modelBuilder.Entity<UF>()
                .HasData(
                new { Id = 1, Nome = "AC" },  new { Id = 2, Nome = "AL" }, 
                new { Id = 3, Nome = "AP" },  new { Id = 4, Nome = "AM" },
                new { Id = 5, Nome = "BA" },  new { Id = 8, Nome = "GO" },  
                new { Id = 9, Nome = "MA" },  new { Id = 6, Nome = "CE" }, 
                new { Id = 7, Nome = "ES" },  new { Id = 10, Nome = "MT" }, 
                new { Id = 11, Nome = "MS" }, new { Id = 12, Nome = "MG" },
                new { Id = 13, Nome = "PA" }, new { Id = 14, Nome = "PB" }, 
                new { Id = 15, Nome = "PR" }, new { Id = 16, Nome = "PE" }, 
                new { Id = 17, Nome = "PI" }, new { Id = 18, Nome = "RJ" }, 
                new { Id = 19, Nome = "RN" }, new { Id = 20, Nome = "RS" }, 
                new { Id = 21, Nome = "RO" }, new { Id = 22, Nome = "RR" }, 
                new { Id = 23, Nome = "SC" }, new { Id = 24, Nome = "SP" }, 
                new { Id = 25, Nome = "SE" }, new { Id = 26, Nome = "TO" }, 
                new { Id = 27, Nome = "DF" });
        }
        #region DBSets<Tables>
        public DbSet<UF> UF { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        #endregion

    }
}
