namespace BancoDigital.Models
{
    public class ContaCorrente : Conta
    {
        public override bool Saque(double valor)
        {
            if(this.Saldo >= valor + 0.15)
            {
                this.Saldo -= valor + 0.15;
                return true;
            }
            return false;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
