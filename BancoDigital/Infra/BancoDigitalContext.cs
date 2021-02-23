using BancoDigital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BancoDigital.Infra
{
    public class BancoDigitalContext : DbContext
    {
        public BancoDigitalContext(DbContextOptions<BancoDigitalContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
