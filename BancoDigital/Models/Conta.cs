using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.Models
{
    public abstract class Conta
    {
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }
        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public abstract bool Saque(double valor);

    }
}
