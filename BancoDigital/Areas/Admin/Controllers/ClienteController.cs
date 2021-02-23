using BancoDigital.DAO;
using BancoDigital.Filters;
using BancoDigital.Infra;
using BancoDigital.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BancoDigital.Areas.Admin.Controllers
{
    [Area("Admin")] [AutorizacaoFilter]
    public class ClienteController : Controller 
    {
        private ClienteDAO dao;

        public ClienteController(ClienteDAO dao)
        {
            this.dao = dao;
        }

        public IActionResult Index()
        {
            return View("Novo");
        }
        public IActionResult Novo()
        {
            var model = new Cliente();
            return View(model);
        }

        [HttpCliente]
        public IActionResult Adiciona(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                dao.Adiciona(cliente);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Novo", cliente);
            }
           
        }
        public IActionResult RemoveCliente(int id)
        {
            dao.Remove(id);
            return RedirectToAction("Novo");
        }
    }
    internal class HttpClienteAttribute : Attribute
    {
    }
}
