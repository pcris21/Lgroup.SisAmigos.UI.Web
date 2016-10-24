using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LGroup.SisAmigos.DataAccess;
using LGroup.SisAmigos.DataAccess.Repository;
using LGroup.SisAmigos.Entities;

namespace LGroupSisAmigos.Test.DataAcess
{
    [TestClass]
    public class AmigoRepositoryTest
    {
        [TestMethod]
        public void Cadastro_De_Amigos()
        {
            var novoCliente = new Cliente();
            novoCliente.CodigoSexo = 2;
            novoCliente.Nome = "Nome Teste 02";
            novoCliente.Email = "Email Teste 02";
            novoCliente.DataNascimento = DateTime.Now;
            novoCliente.Telefone = "11 9999-9991";

            var dadosCliente = new ClienteRepository();
            dadosCliente.Cadastrar(novoCliente);
        }

        [TestMethod]
        public void Testar_Lista_De_Amigos()
        {
            var dadosCliente = new ClienteRepository();
            var clientes = dadosCliente.Listar();
        }

        [TestMethod]
        public void Testar_Exclusao_De_Amigos()
        {
            var dadosCliente = new ClienteRepository();
            dadosCliente.Excluir(3);
        }
    }
}
