using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.SisAmigos.Entities;

namespace LGroup.SisAmigos.DataAccess.Repository
{
    //como naõ temos uma tela cadastrar sexo teremos somente lista
   public sealed class SexoRepository
    {

        public IEnumerable<Sexo>  Listar()
        {

            var conexao = new Conexao();
            var sexos = conexao.Sexos.ToList(); // select * from sexo


            return sexos;
        }
    }
}
