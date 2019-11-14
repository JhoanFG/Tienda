using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class Customer
    {
        public List<Models.DB.Customer> GetCustomer(string userId)
        {
            var _context = new DAL.Models.ShopEntities();

            var listCustomer = (from q in _context.Customer
                                where q.UserId == userId
                                select new Models.DB.Customer
                                {
                                    Id = q.Id,
                                    DocumentTypeId = q.DocumentTypeId,
                                    DocumentNumber = q.DocumentNumber,
                                    FirstName = q.FirstName,
                                    SecondName = q.SecondName,
                                    Surname = q.Surname,
                                    SecondSurname = q.SecondSurname,
                                    Telephone = q.Telephone,
                                    Address = q.Address,
                                    CityId = q.CityId,
                                    UserId = q.UserId,
                                }).ToList();
            
            return listCustomer;
        }
    }
}