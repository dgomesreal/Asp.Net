using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.Controllers
{
    public class AdministracaoController : Controller
    {
        public IActionResult Realatorio()
        {
            return View();
        }
    }
}
