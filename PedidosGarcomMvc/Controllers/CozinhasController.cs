using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosGarcomMvc.Data;
using PedidosGarcomMvc.Services;

namespace PedidosGarcomMvc.Controllers
{
    public class CozinhasController : Controller
    {
        private readonly PedidosGarcomMvcContext _context;
        private readonly CozinhaService _cozinhaService;

        public CozinhasController(CozinhaService cozinhaService, PedidosGarcomMvcContext context)
        {
            _cozinhaService = cozinhaService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Pedido.ToList());
        }
    }
}
