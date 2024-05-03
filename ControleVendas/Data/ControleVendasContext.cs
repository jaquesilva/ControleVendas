using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleVendas.Models;

namespace ControleVendas.Data
{
    public class ControleVendasContext : DbContext
    {
        public ControleVendasContext (DbContextOptions<ControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ControleVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<ControleVendas.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<ControleVendas.Models.Login> Login { get; set; } = default!;
        public DbSet<ControleVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<ControleVendas.Models.Venda> Venda { get; set; } = default!;
        public DbSet<ControleVendas.Models.Administrador> Administrador { get; set; } = default!;
    }
}
