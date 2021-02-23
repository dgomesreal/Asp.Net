using BancoDigital.Infra;
using BancoDigital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.DAO
{
    public class UsuarioDAO
    {
        private BancoDigitalContext contexto;

        public UsuarioDAO(BancoDigitalContext contexto)
        {
            this.contexto = contexto;
        }

        public Usuario Busca(string login, string senha)
        {
            return contexto.Usuarios
                        .Where(usuario => usuario.Nome.Equals(login) && usuario.Senha.Equals(senha))
                        .FirstOrDefault<Usuario>();
        }

        public void Adiciona(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }
    }
}
