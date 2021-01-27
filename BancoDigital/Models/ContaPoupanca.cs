using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.Models
{
    public class ContaPoupanca : Conta
    {
        public override bool Saque(double valor)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= 0.10;
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
