using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosGarcomMvc.Data;


namespace PedidosGarcomMvc.Controllers
{
    public class CopasController : Controller
    {
        private readonly PedidosGarcomMvcContext _context;


        public CopasController(PedidosGarcomMvcContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Pedido.ToList());
        }
    }
}
