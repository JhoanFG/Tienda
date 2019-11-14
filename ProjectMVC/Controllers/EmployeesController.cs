using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Logica.Models.BindingModels.EmployeesCreateBindingModel model)
        {
            if (ModelState.IsValid)
            {
                int id = model.Id;
                string firstName = model.FirstName;
                string secondName = model.SecondName;

                var createViewModel = new Logica.Models.ViewModels.EmployeesCreateViewModel();
                createViewModel.Name = string.Format("{0} {1}", firstName, secondName);

                ViewBag.Name = createViewModel.Name;
                ViewBag.Id = id;

                return View();
            }

            return View(model);
        }
    }
}