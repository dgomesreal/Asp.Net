namespace BancoDigital.Models
{
    public class Cliente
    {
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
