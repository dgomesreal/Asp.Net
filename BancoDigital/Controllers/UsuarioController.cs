using BancoDigital.DAO;
using BancoDigital.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BancoDigital.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO;
        
        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Autentica(LoginViewModel model)
        {
            Usuario usuario = this.usuarioDAO.Busca(model.Login, model.Password);
            if (usuario != null)
            {
                HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(usuario));
                return RedirectToAction("Index", "Cliente", new { Areas = "Admin"});
            }
            else
            {
                ModelState.AddModelError("login.Invalido", "Login ou senha incorretos");
            }
            return View("Login", model);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario()
                {
                    Nome = model.LoginName,
                    Email = model.Email,
                    Senha = model.Senha,
                };
                usuarioDAO.Adiciona(usuario);
                return RedirectToAction("Login");
            }   
            return View("Novo", model);
        }
    }
}
