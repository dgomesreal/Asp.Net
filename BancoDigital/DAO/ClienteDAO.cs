using BancoDigital.Controllers;
using BancoDigital.Infra;
using BancoDigital.Models;
using System.Collections.Generic;
using System.Linq;

namespace BancoDigital.DAO
{
    public class ClienteDAO
    {
        private BancoDigitalContext contexto;

        public ClienteDAO(BancoDigitalContext contexto)
        {
            this.contexto = contexto;
        }
        public List<Cliente> Lista()
        {
                var lista = contexto.Clientes.ToList();
                return lista;
        }

        public void Adiciona(Cliente cliente) 
        { 
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
        } 

        public void Remove(int id)
        {        
                Cliente cliente = contexto.Clientes.Find(id);
                contexto.Clientes.Remove(cliente);
                contexto.SaveChanges();
        }
    }
}
