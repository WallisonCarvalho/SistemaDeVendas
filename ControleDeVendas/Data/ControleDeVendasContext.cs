using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleDeVendas.Models;

namespace ControleDeVendas.Data
{
    public class ControleDeVendasContext : DbContext
    {
        public ControleDeVendasContext (DbContextOptions<ControleDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Vendedor> Vendedor { get; set; }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Venda> Venda { get; set; }
    }
}
