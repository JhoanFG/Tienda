﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class SalesDetails
    {
        public int Id { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? SubtotalValue { get; set; }

        public Products Products { get; set; }
        public Sales Sales { get; set; }
    }
}
