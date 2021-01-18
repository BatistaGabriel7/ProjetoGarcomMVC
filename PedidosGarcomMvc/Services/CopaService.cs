using PedidosGarcomMvc.Data;
using PedidosGarcomMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PedidosGarcomMvc.Services;


namespace PedidosGarcomMvc.Services
{
    public class CopaService
    {
        private readonly PedidosGarcomMvcContext _context;

        public CopaService(PedidosGarcomMvcContext context)
        {
            _context = context;
        }

        public List<Copa> FindAll()
        {
            return _context.Copa.ToList(); //pega todos os dados dos pedidos e converte para uma lista
        }

        public void Insert(Copa obj)
        {
            obj.Pedidos = (ICollection<Pedido>)_context.Pedido.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
