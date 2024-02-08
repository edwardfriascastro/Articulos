using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Articulos.Models;

namespace Articulos.Data
{
    public class ArticulosContext : DbContext
    {
        public ArticulosContext (DbContextOptions<ArticulosContext> options)
            : base(options)
        {
        }

        public DbSet<Articulos.Models.Articulo> Articulo { get; set; } = default!;
    }
}
