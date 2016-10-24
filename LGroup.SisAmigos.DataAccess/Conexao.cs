using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LGroup.SisAmigos.Entities;

namespace LGroup.SisAmigos.DataAccess
{
   public sealed class Conexao : DbContext // esta classe é a classe de comunicação com o entity. Equivale a sqlconnecton
    {
        public Conexao() : base(@"Data source=LAPTOP-9QI5US4G\SQLEXPRESS; Initial Catalog=DBCursoMVC5; Integrated Security=True;")
        {

        }

        //A classe responsavel por fazer CRUD é a DBSET

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Sexo> Sexos { get; set; }

        //dentor da conexão temos que inserir os mapeamentos de tabelas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //este método é responsavel executar os mapeamentos no banco. É executado sempre que fizermos conexão com o banco
            modelBuilder.Configurations.Add(new Mapping.SexoMapping());
            modelBuilder.Configurations.Add(new Mapping.ClienteMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
