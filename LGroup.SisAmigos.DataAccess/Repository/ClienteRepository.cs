using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.SisAmigos.Entities;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace LGroup.SisAmigos.DataAccess.Repository
{
    public sealed class ClienteRepository
    {
        //quando declaramos uma variavel como readonly ela ocupa sempre o mesmo endereço de memória, mesmo se for limpada pelo GC. 
        //Isso gera ganho de performance

        private readonly Conexao _conexao = new Conexao();
        public IEnumerable<Cliente> Listar()
        {

            return _conexao.Clientes.ToList();
        }
        public void Cadastrar(Cliente clienteTela)
        {

            //Cadastramos o cliente que vem da tela. Isso equivale a um INSERT INTO TB_CLIENTE

            _conexao.Clientes.Add(clienteTela);
            _conexao.SaveChanges();

        }
        public void Atualizar(Cliente clienteTela)
        {
            _conexao.Entry(clienteTela).State = EntityState.Modified;
            _conexao.SaveChanges();

        }

        public void Excluir(Int32 codigoCliente)
        {
            var clienteExcluido = _conexao.Clientes.Find(codigoCliente); //Obtem o Id do cliente
            _conexao.Clientes.Remove(clienteExcluido);
            _conexao.SaveChanges();

        }

        public Cliente Consultar(Int32 codigoCliente)
        {
            var cliente = _conexao.Clientes.Find(codigoCliente);
            // var cliente = _conexao.Clientes.Where(x => x.Codigo == codigoCliente).ToList();
            return cliente;
        }
    }
}
