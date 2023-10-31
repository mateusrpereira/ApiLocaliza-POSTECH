using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    //Fábrica de contexto para criar: bd, tabela, migração...
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar Migrations
            var connectionString = "Server=localhost;Database=dbAPI;Uid=root;Pwd=root";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            //Obs.: foi necessário especificar a versão do mysql instalada
            //optionsBuilder.UseMySql(connectionString);
            
            //optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 31)));
            //testar se vai autodetectar a versão do banco de dados
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            
            return new MyContext(optionsBuilder.Options);
        }
    }
}