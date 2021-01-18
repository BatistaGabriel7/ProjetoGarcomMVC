using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosGarcomMvc.Services;

namespace PedidosGarcomMvc.Controllers
{
    public class CopasController : Controller
    {
        private readonly CopaService _copaService;

        public CopasController(CopaService copaService)
        {
            _copaService = copaService;
        }



        public IActionResult Index()
        {
            var list = _copaService.FindAll(); //retorna uma lista de registros da copa
            return View(list);
        }
    }
}
