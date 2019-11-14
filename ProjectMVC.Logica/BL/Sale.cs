using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.BL
{
    public class Sale
    {
        public int CreateSale(int methodPaymentId,
            double totalValue,
            int customerId) {

            var _context = new DAL.Models.ShopEntities();

            _context.Sales.Add(new DAL.Models.Sales {
                MethodPaymentId = methodPaymentId,
                TotalValue = totalValue,
                Date = DateTime.Now,
                CustomerId = customerId
            });
            _context.SaveChanges();

            var id = (from q in _context.Sales
                      select q.Id).LastOrDefault();

            return id;
        }

        public void CreateSaleDetails(int saleId,
            int productId,
            int quantity,
            double price)
        {
            var _context = new DAL.Models.ShopEntities();

            _context.SaleDetails.Add(new DAL.Models.SaleDetails {
                ProductId = productId,
                Quantity = quantity,
                SaleId = saleId,
                SubtotalValue = price * quantity
            });
            _context.SaveChanges();
        }
    }
}
