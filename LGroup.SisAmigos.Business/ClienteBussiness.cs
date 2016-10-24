using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.SisAmigos.DataAccess.Repository;
using LGroup.SisAmigos.Entities;


namespace LGroup.SisAmigos.Business
{
   public sealed class ClienteBussiness
    {
        private ClienteRepository _dadosCliente = new ClienteRepository();
        public void Cadastrar(Cliente novaCliente)
        {
            _dadosCliente.Cadastrar(novaCliente);
        }

        public IEnumerable<Cliente> Listar()
        {
            return _dadosCliente.Listar();
        }

        public void Excluir(Int32 codigoCliente)
        {
            _dadosCliente.Excluir(codigoCliente);
        }

        public void Atualizar(Cliente clienteAlterado)
        {
            _dadosCliente.Atualizar(clienteAlterado);
        }

        public Cliente Consultar(int codigoCliente)
        {
           return _dadosCliente.Consultar(codigoCliente);
        }
       
    }
}
