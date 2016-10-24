using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.SisAmigos.DataAccess.Repository;
using LGroup.SisAmigos.Entities;

namespace LGroup.SisAmigos.Business
{
   public sealed class SexoBussiness
    {
        private SexoRepository _dadosSexo = new SexoRepository();
        public IEnumerable<Sexo> Listar()
        {
            return _dadosSexo.Listar();
        }
    }
}
