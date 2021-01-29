using System.ComponentModel.DataAnnotations;

namespace BancoDigital.Models
{
    public class Cliente
    {
        [StringLength(50, ErrorMessage = "Digite até 50 letras")] [Required(ErrorMessage = "Digite um Nome!")]
        public string Nome { get; set; }
        //public int Cpf { get; set; }
        //public string Endereco { get; set; }

        public int Id { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente()
        {

        }
    }
}
