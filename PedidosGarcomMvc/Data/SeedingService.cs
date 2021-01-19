using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedidosGarcomMvc.Models;

namespace PedidosGarcomMvc.Data
{
    public class SeedingService
    {
        private PedidosGarcomMvcContext _context;
        public SeedingService (PedidosGarcomMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Pedido.Any() ||
                _context.Copa.Any() ||
                _context.Cozinha.Any())
            {
                return;
            }


            Cozinha c1 = new Cozinha(1, 1, "Macarrão", 1);
            Cozinha c2 = new Cozinha(2, 3, "Strogonoff", 1);
            Cozinha c3 = new Cozinha(3, 2, "Lasanha", 2);


            Copa co1 = new Copa(1, 1, "Pepsi", 2);
            Copa co2 = new Copa(2, 3, "Guaraná", 1);
            Copa co3 = new Copa(3, 2, "Coca cola", 1);

            Pedido p1 = new Pedido(1, 1, "João Pedro", "Macarrão", 1, "Pepsi", 2, co1, c1);
            Pedido p2 = new Pedido(2, 3, "Gabriel", "Strogonoff", 1, "Guaraná", 1, co2, c2);
            Pedido p3 = new Pedido(3, 2, "Henrique", "Lasanha", 2, "Coca cola", 1, co3, c3);

            _context.Cozinha.AddRange(c1, c2, c3);

            _context.Copa.AddRange(co1, co2, co3);

            _context.Pedido.AddRange(p1, p2, p3);

            _context.SaveChanges();           

        }
    }
}
