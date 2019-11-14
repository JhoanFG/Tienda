using System.Collections.Generic;
using System.Linq;

namespace ProjectMVC.Logica.BL
{
    public class MethodPayment
    {
        public List<Models.DB.MethodPayment> GetMethodPayments()
        {
            var _context = new DAL.Models.ShopEntities();

            var listMethodPayments = (from q in _context.Categories
                                  select new Models.DB.MethodPayment
                                  {
                                      Id = q.Id,
                                      Name = q.Name,
                                      Active = q.Active
                                  }).ToList();

            return listMethodPayments;
        }
    }
}
