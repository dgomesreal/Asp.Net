using BancoDigital.DAO;
using BancoDigital.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BancoDigital.Controllers
{
    public class ClienteController : Controller 
    {
        public IActionResult Index()
        {
            return View();
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
                ClienteDAO dao = new ClienteDAO();
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
            ClienteDAO dao = new ClienteDAO();
            dao.Remove(id);
            return RedirectToAction("Index","Home");
        }
    }
    internal class HttpClienteAttribute : Attribute
    {
    }
}
