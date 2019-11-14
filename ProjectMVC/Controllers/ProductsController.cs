using IdentitySample.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ProductsController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ProductsController()
        {

        }

        // GET: Products
        public async Task<ActionResult> Index()
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            Logica.BL.Products products = new Logica.BL.Products();

            var listProducts = (from q in products.GetProducts()
                                select new Logica.Models.ViewModels.ProductsIndexViewModel
                                {
                                    Id = q.Id,
                                    Name = q.Name,
                                    Guid = q.Guid,
                                    Extension = q.Extension,
                                    CategoryId = q.CategoryId,
                                    Price = q.Price,
                                    ShippingCost = q.ShippingCost,
                                    Warranty = q.Warranty,
                                    Description = q.Description,
                                    Quantity = q.Quantity,
                                    StateId = q.StateId,
                                    CustomerId = q.CustomerId
                                }).ToList();

            return View(listProducts);
        }

        //Index para Categorias.
        public ActionResult IndexCategories(int id)
        {
            Logica.BL.Products products = new Logica.BL.Products();

            var listProducts = (from q in products.GetProducts()
                                where q.CategoryId == id
                                select new Logica.Models.ViewModels.ProductsIndexViewModel
                                {
                                    Id = q.Id,
                                    Name = q.Name,
                                    Guid = q.Guid,
                                    Extension = q.Extension,
                                    CategoryId = q.CategoryId,
                                    Price = q.Price,
                                    ShippingCost = q.ShippingCost,
                                    Warranty = q.Warranty,
                                    Description = q.Description,
                                    Quantity = q.Quantity,
                                    StateId = q.StateId,
                                    CustomerId = q.CustomerId
                                }).ToList();

            return View(listProducts);
        }

        //Detalles
        public ActionResult Details(int? id)
        {
            Logica.BL.Products products = new Logica.BL.Products();

            var product = products.GetProducts().Where(x => x.Id == id).FirstOrDefault();

            var productsDetailsViewModel = new Logica.Models.ViewModels.ProductsDetailsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Guid = product.Guid,
                Extension = product.Extension,
                CategoryId = product.CategoryId,
                Price = product.Price,
                ShippingCost = product.ShippingCost,
                Warranty = product.Warranty,
                Description = product.Description,
                Quantity = product.Quantity,
                StateId = product.StateId,
                CustomerId = product.CustomerId
            };

            //Variable de Sesion:
            Session["product"] = productsDetailsViewModel;

            return View(productsDetailsViewModel);
        }


        //public ActionResult Create(ProjectMVC.Logica.Models.BindingModels.ProductsCreateBindingModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Logica.BL.Products products = new Logica.BL.Products();
        //        products.CreateProducts(model.Title,
        //            model.Details,
        //            model.ExpirationDate,
        //            model.IsCompleted,
        //            model.Effort,
        //            model.RemainingWork,
        //            model.StateId,
        //            model.ActivityId,
        //            model.PriorityId,
        //            model.ProjectId);

        //        return RedirectToAction("Index", new { projectId = model.ProjectId });
        //    }

        //    Logica.BL.States states = new Logica.BL.States();
        //    ViewBag.States = states.GetStates();

        //    Logica.BL.Activities activities = new Logica.BL.Activities();
        //    ViewBag.Activities = activities.GetActivities();

        //    Logica.BL.Priorities priorities = new Logica.BL.Priorities();
        //    ViewBag.Priorities = priorities.GetPriorities();

        //    return View(model);

        //    return View(model);
        //}
    }
}