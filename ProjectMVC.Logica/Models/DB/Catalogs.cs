using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class Catalogs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int? CategoryId { get; set; }

        public Categories Categories { get; set; }
    }
}
