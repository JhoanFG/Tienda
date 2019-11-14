using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class Catalogs
    {
        public List<Models.DB.Catalogs> GetCatalogs()
        {
            var _context = new DAL.Models.ShopEntities();

            var listCategories = (from q in _context.Categories
                                  select new Models.DB.Categories
                                  {
                                      Id = q.Id,
                                      Name = q.Name,
                                      Active = q.Active
                                  }).ToList();

            var listCatalogs = (from q in _context.Catalogs
                                select new Models.DB.Catalogs
                                {
                                    Id = q.Id,
                                    Name = q.Name,
                                    CategoryId = q.CategoryId,
                                    Categories = new Models.DB.Categories { Id = (int)q.CategoryId }
                                }).ToList();

            return listCatalogs;
        }
    }
}
