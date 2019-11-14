using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            Logica.BL.Categories categories = new Logica.BL.Categories();

            var listCategories = (from q in categories.GetCategories()
                                select new Logica.Models.ViewModels.CategoriesIndexViewModel
                                {
                                    Id = q.Id,
                                    Name = q.Name,
                                    Active = q.Active   
                                }).ToList();

            return RedirectToAction("IndexProducts");
        }

        public ActionResult IndexProducts(int? categoryId)
        {
            Logica.BL.Categories categories = new Logica.BL.Categories();
            var listCategories = (from q in categories.GetCategories()
                                  select new Logica.Models.ViewModels.CategoriesIndexViewModel
                                  {
                                      Id = q.Id,
                                      Name = q.Name,
                                      Active = q.Active
                                  }).ToList();

            return View(listCategories);
        }

        public ActionResult VideoGames()
        {
            Logica.BL.Products videoJuegos = new Logica.BL.Products();

            var listVideojuegos = (from q in videoJuegos.GetProducts()
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

            return View(listVideojuegos);
        }

        public ActionResult Clothes()
        {
            Logica.BL.Products videoJuegos = new Logica.BL.Products();

            var listRopa = (from q in videoJuegos.GetProducts()
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

            return View(listRopa);
        }
    }
}