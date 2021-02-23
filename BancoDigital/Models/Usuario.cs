using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite um Nome Válido!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite um E-mail!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite uma Senha!")]
        public string Senha { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
