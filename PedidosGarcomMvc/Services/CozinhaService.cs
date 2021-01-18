using PedidosGarcomMvc.Data;
using PedidosGarcomMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosGarcomMvc.Services
{
    public class CozinhaService
    {
        private readonly PedidosGarcomMvcContext _context;

        public CozinhaService(PedidosGarcomMvcContext context)
        {
            _context = context;
        }

        public List<Cozinha> FindAll()
        {
            return _context.Cozinha.ToList(); //pega todos os dados dos pedidos e converte para uma lista
        }

        public void Insert(Cozinha obj)
        {
            obj.Pedidos = (ICollection<Pedido>)_context.Pedido.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
