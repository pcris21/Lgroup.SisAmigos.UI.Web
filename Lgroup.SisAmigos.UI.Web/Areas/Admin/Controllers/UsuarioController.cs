using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lgroup.SisAmigos.UI.Web.Areas.Admin.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Admin/Usuario
        public ActionResult Login()
        {
            return View();
        }
    }
}