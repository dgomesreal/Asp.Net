using BancoDigital.Infra;
using BancoDigital.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.DAO
{
    public class ClienteDAO
    {
        public List<Cliente> Lista()
        {
            using (BancoDigitalContext contexto = new BancoDigitalContext()) 
            {
                var lista = contexto.Clientes.ToList();
                return lista;
            }
        }

        public void Adiciona(Cliente cliente) 
        { 
            using (BancoDigitalContext contexto = new BancoDigitalContext()) 
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            } 
        } 
    }
}
