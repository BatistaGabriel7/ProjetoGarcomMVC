using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedidosGarcomMvc.Models;

namespace PedidosGarcomMvc.Data
{
    public class PedidosGarcomMvcContext : DbContext
    {
        public PedidosGarcomMvcContext (DbContextOptions<PedidosGarcomMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Copa> Copa { get; set; }
        public DbSet<Cozinha> Cozinha { get; set; }
    }
}
