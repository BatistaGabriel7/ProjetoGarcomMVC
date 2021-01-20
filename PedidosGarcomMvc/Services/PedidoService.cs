using PedidosGarcomMvc.Data;
using PedidosGarcomMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosGarcomMvc.Services
{
    public class PedidoService
    {
        private readonly PedidosGarcomMvcContext _context;

        public PedidoService(PedidosGarcomMvcContext context)
        {
            _context = context;
        }

        public List<Pedido> FindAll()
        {
            return _context.Pedido.ToList();
        }

        //public void Insert(Pedido obj)
        //{
        //    _context.Add(obj);
        //    _context.SaveChanges();
        //}

    }
}
