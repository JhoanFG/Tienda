using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Controllers
{
    public class CatalogsController : Controller
    {
        // GET: Catalogos
        public ActionResult Index()
        {
            return View();
        }
    }
}