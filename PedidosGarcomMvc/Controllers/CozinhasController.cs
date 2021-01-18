using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidosGarcomMvc.Services;

namespace PedidosGarcomMvc.Controllers
{
    public class CozinhasController : Controller
    {
        private readonly CozinhaService _cozinhaService;

        public CozinhasController(CozinhaService cozinhaService)
        {
            _cozinhaService = cozinhaService;
        }
        public IActionResult Index()
        {
            var list = _cozinhaService.FindAll(); //retorna uma lista de registros da cozinha
            return View(list);
        }
    }
}
