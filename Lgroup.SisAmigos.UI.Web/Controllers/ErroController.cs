﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lgroup.SisAmigos.UI.Web.Controllers
{
    public class ErroController : Controller
    {
        public ActionResult Erro404()
        {
            return View();
        }
    }
}