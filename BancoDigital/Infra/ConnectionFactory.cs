using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDigital.Infra
{
    public class ConnectionFactory
    {
        public static SqlConnection CriaConexaoAberta()
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddEnvironmentVariables();
            IConfiguration configuration = builder.Build(); 
            string stringConexao = configuration.GetConnectionString("BancoDigital"); 
            SqlConnection conexao = new SqlConnection(stringConexao); 
            conexao.Open();
            return conexao;
        }
    }
}
