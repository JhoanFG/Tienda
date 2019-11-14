using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class Sales
    {
        public int Id { get; set; }
        public int? MethodPaymentId { get; set; }
        public double? TotalValue { get; set; }
        public DateTime? Date { get; set; }
        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }
        public MethodPayment MethodPayment { get; set; }
    }
}
