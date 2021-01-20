using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosGarcomMvc.Data;
using PedidosGarcomMvc.Services;

namespace PedidosGarcomMvc.Controllers
{
    public class CopasController : Controller
    {
        private readonly PedidosGarcomMvcContext _context;
        private readonly CopaService _copaService;

        public CopasController(CopaService copaService, PedidosGarcomMvcContext context)
        {
            _copaService = copaService;
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Pedido.ToList());
        }
        //public IActionResult Index()
        //{
        //    var list = _copaService.FindAll(); //retorna uma lista de registros da copa
        //    return View(list);
        //}
    }
}
