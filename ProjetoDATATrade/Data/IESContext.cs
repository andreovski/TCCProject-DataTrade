using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoDATATrade.Models;

namespace ProjetoDATATrade.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Carteira> Carteiras { get; set; }

        public DbSet<Estrategia> Estrategias { get; set; }

        public DbSet<Operacao> Operacoes { get; set; }

        public DbSet<Trader> Traders { get; set; }
        

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //       builder.Entity<Login>().HasKey(m => m.LoginID);
        //       base.OnModelCreating(builder);
        //}
    }
}
