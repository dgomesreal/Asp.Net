using BancoDigital.DAO;
using BancoDigital.Infra;
using BancoDigital.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
            return View();
        }

        [HttpCliente]
        public IActionResult Adiciona(Cliente cliente)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Adiciona(cliente);
            return RedirectToAction("Index", "Home");
        }
    }
    internal class HttpClienteAttribute : Attribute
    {
    }
}
