using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// Antes de criar as telas (views) temos primeiro que criar as classes controller
/// é no controller que programamos as telas
/// Todas as regras de negócio, consistencias, validações ficam dentro do controller
/// É no controller qued definimos as quantidade de telas
/// </summary>
namespace Lgroup.SisAmigos.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        //Para cada view temos que criar um apelido: Action, ação ou apelido
        //Atalha para criar action: mvcaction4 2xtab
        //Para navegar nas telas temos que seguir a ordem: controller/action

        //Tela inicial
        public ActionResult Index()
        {
            return View(); //devolve a tela para o navegador. Abre o CSHTML e leva para o navegador

        }
      
    }
}