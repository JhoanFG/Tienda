using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class Categories
    {
        public List<Models.DB.Categories> GetCategories()
        {
            var _context = new DAL.Models.ShopEntities();

            var listCategories = (from q in _context.Categories
                                  select new Models.DB.Categories
                                  {
                                      Id = q.Id,
                                      Name = q.Name,
                                      Active= q.Active
                                  }).ToList();

            return listCategories;
        }
    }
}