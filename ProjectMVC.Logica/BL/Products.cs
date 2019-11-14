using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class Products
    {
        public List<Models.DB.Products> GetProducts()
        {
            var _context = new DAL.Models.ShopEntities();

            var listProductPhotos = (from q in _context.ProductPhotos
                                     select new Models.DB.ProductPhotos
                                     {
                                         Id = q.Id,
                                         ProductId = q.ProductId,
                                         Guid = q.Guid,
                                         Extension = q.Extension
                                     }).ToList();     

            var listProducts = (from q in _context.Products
                                select new Models.DB.Products
                                {
                                    Id = q.Id,
                                    Name = q.Name,  
                                    CategoryId = q.CategoryId,
                                    Price = q.Price,
                                    ShippingCost = q.ShippingCost,
                                    Warranty = q.Warranty,
                                    Description = q.Description,
                                    Quantity = q.Quantity,
                                    StateId = q.StateId,
                                    CustomerId = q.CustomerId,
                                    Categories = new Models.DB.Categories { Id = (int)q.CategoryId },
                                    States = new Models.DB.States { Id = (int)q.StateId },
                                    Customer = new Models.DB.Customer { Id = (int)q.CustomerId }                                    
                                }).ToList();

            foreach (var item in listProducts)
            {
                item.Guid = listProductPhotos.Where(x => x.ProductId == item.Id).Select(x => x.Guid).FirstOrDefault();
                item.Extension = listProductPhotos.Where(x => x.ProductId == item.Id).Select(x => x.Extension).FirstOrDefault();
            }

            return listProducts;
        }

        public void CrateProducts() { }
    }
}