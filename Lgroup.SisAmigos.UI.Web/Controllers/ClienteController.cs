using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lgroup.SisAmigos.UI.Web.ViewModels;
using LGroup.SisAmigos.Business;
using LGroup.SisAmigos.Entities;
using FastMapper;
using System.Web.Caching;

namespace Lgroup.SisAmigos.UI.Web.Controllers
{

    [HandleError]
    public class ClienteController : Controller
    {

        private ClienteBussiness _negocioCliente = new ClienteBussiness();
        private SexoBussiness _negocioSexo = new SexoBussiness();

        /// <summary>
        /// Lista todos os clientes
        /// </summary>
        /// <returns></returns>
        public ActionResult Listar()
        {

            var clientesTabela = _negocioCliente.Listar();
            var clientesTela = TypeAdapter.Adapt<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientesTabela); //Lista de Cliente(entity) será convetidada para Model
            return View(clientesTela);

        }


        /// <summary>
        /// carrega a tela cadastrar
        /// </summary>
        /// <returns></returns>
        //OutputCache[(Duration = 60)]
        public ActionResult Cadastrar()
        {
            //Deixando as telas que são carregadas com frequencia e que seu contéudo nao seja alterado com frequencia podem ser deixadas em cache.
            //a configuração do tempo é em segundos

            var vmCliente = new ClienteViewModel();

            //quando criamos um SELECTLIST passamos 3 parametros: 1) Lista de registros; 2) Nome do campo que é chave primaria
            //3) Nome do campo que é texto
            var sexosTabela = _negocioSexo.Listar();

            var sexosTela = TypeAdapter.Adapt<IEnumerable<Sexo>, IEnumerable<SexoViewModel>>(sexosTabela);//lista de sexo será transformada em SexoViewModel
            vmCliente.ListaSexos = new SelectList(sexosTela, "Codigo", "Descricao");

            return View(vmCliente);

        }


        /// <summary>
        /// Cadastra cliente
        /// </summary>
        /// <param name="dadosTela"></param>
        /// <returns></returns>
        [HttpPost] //mvcpostaction4
        public ActionResult Cadastrar(ClienteViewModel dadosTela)
        {

            //Só chega na action sem validação se o javascript estiver desabilidatado. Neste caso deve ser valiado também no lado servidor atraves
            //ModelStatate, onde temos as informações dos campos que não foram preenchidos corretamente
            if (!ModelState.IsValid)
            {
                return View();

            }

            var dadosTabela = TypeAdapter.Adapt<ClienteViewModel, Cliente>(dadosTela); //converte modelView para entity

            _negocioCliente.Cadastrar(dadosTabela);

            TempData.Add("Mensagem", "Cliente cadastrado com sucesso");

            return RedirectToAction("Listar"); //Para levar o usuario para outra tela usamos o comando RedirectToAction
        }

        /// <summary>
        /// Carrega a tela Editar Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Editar(int id)
        {
            //Traz dados do cliente para editar
            var clienteEditar = _negocioCliente.Consultar(id);

            //Traz dados da tabela sexo para carregar combo
            var sexosTabela = _negocioSexo.Listar();
            var sexosTela = TypeAdapter.Adapt<IEnumerable<Sexo>, IEnumerable<SexoViewModel>>(sexosTabela);

            //Exibe na tela
            var clienteTela = TypeAdapter.Adapt<Cliente, ClienteViewModel>(clienteEditar);
            clienteTela.ListaSexos = new SelectList(sexosTela, "Codigo", "Descricao");
            TempData["CodigoCliente"] = clienteTela.Codigo;
            return View(clienteTela);
        }

        /// <summary>
        /// Grava os dados editados
        /// </summary>
        /// <param name="dadosTela"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Editar(ClienteViewModel dadosTela)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dadosTabela = TypeAdapter.Adapt<ClienteViewModel, Cliente>(dadosTela);
            dadosTabela.Codigo = (int)TempData["CodigoCliente"];
            _negocioCliente.Atualizar(dadosTabela);

            TempData.Add("Mensagem", "Cliente Alterado com sucesso");
            return RedirectToAction("Listar");
        }

        /// <summary>
        /// Exclui um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Excluir(Int32 id)
        {
            //Na rota padrão do MVC o terceiro parametro semrpe se chama id que é uma palavra reservado do mvc. 
            //Para pegar o terceiro parametro usar um parametro chamado id

            _negocioCliente.Excluir(id);
            TempData.Add("Mensagem", "Cliente Excluido com sucesso");
            return RedirectToAction("Listar");
        }
    }
}