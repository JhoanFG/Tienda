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
    public class SalesController : Controller
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

        public SalesController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public SalesController()
        {

        }

        // GET: Sales
        public async Task<ActionResult> ShippingCost()
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            var productsDetailsViewModel = (Logica.Models.ViewModels.ProductsDetailsViewModel)Session["product"];

            Logica.BL.Customer customer = new Logica.BL.Customer();
            var customerDetailsViewModel = (from q in customer.GetCustomer(user.Id)
                                            select new Logica.Models.ViewModels.CustomerDetailsViewModel
                                            {
                                                Address = q.Address
                                            }).FirstOrDefault();

            ViewBag.Product = productsDetailsViewModel;
            ViewBag.Customer = customerDetailsViewModel;

            return View();
        }

        public ActionResult MethodPayment(double shippingCost)
        {
            var productsDetailsViewModel = (Logica.Models.ViewModels.ProductsDetailsViewModel)Session["product"];
            productsDetailsViewModel.ShippingCost = shippingCost;
            Session["product"] = productsDetailsViewModel;
            ViewBag.Product = productsDetailsViewModel;

            Logica.BL.MethodPayment methodPayment = new Logica.BL.MethodPayment();
            var listMethodPaymentViewModel = (from q in methodPayment.GetMethodPayments()
                                              select new Logica.Models.ViewModels.MethodPaymentDetailsViewModel
                                              {
                                                  Id = q.Id,
                                                  Name = q.Name,
                                                  Active = q.Active
                                              }).ToList();
            ViewBag.MethodPayments = listMethodPaymentViewModel;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Sale(Logica.Models.BindingModels.SalesMethodPaymentBindingModel model)
        {
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);

            var productsDetailsViewModel = (Logica.Models.ViewModels.ProductsDetailsViewModel)Session["product"];
            ViewBag.Product = productsDetailsViewModel;

            Logica.BL.Customer customer = new Logica.BL.Customer();
            var customerDetailsViewModel = (from q in customer.GetCustomer(user.Id)
                                            select new Logica.Models.ViewModels.CustomerDetailsViewModel
                                            {
                                                Address = q.Address
                                            }).FirstOrDefault();

            var methodPaymentId = model.MethodPaymentId;

            Logica.BL.Sale sale = new Logica.BL.Sale();
            var id = sale.CreateSale(methodPaymentId, 
                productsDetailsViewModel.Price.Value,
                customerDetailsViewModel.Id);
            ViewBag.Id = id;

            sale.CreateSaleDetails(id, 
                productsDetailsViewModel.Id,
                1,
                productsDetailsViewModel.Price.Value);

            Session.Remove("product");

            return View();
        }
    }
}