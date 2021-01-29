using BancoDigital.Controllers;
using BancoDigital.Infra;
using BancoDigital.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Remove(int id)
        {
            using(BancoDigitalContext contexto = new BancoDigitalContext())
            {
                Cliente cliente = contexto.Clientes.Find(id);
                contexto.Clientes.Remove(cliente);
                contexto.SaveChanges();
            }
        }
    }
}
