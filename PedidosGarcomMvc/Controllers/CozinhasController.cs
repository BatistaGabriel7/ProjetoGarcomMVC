using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosGarcomMvc.Data;


namespace PedidosGarcomMvc.Controllers
{
    public class CozinhasController : Controller
    {
        private readonly PedidosGarcomMvcContext _context;
        
        public CozinhasController(PedidosGarcomMvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Pedido.ToList());
        }
    }
}
