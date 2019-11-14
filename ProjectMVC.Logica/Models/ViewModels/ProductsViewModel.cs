using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.ViewModels
{
    public class ProductsIndexViewModel
    {
        [Display (Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "CategoryId")]
        public int? CategoryId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public double? Price { get; set; }

        [Display(Name = "ShippingCost")]
        public double? ShippingCost { get; set; }

        [Display(Name = "Warranty")]
        public string Warranty { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }

        [Display(Name = "StateId")]
        public int? StateId { get; set; }

        [Display(Name = "CustomerId")]
        public int? CustomerId { get; set; }

        [Display(Name = "Guid")]
        public String Guid { get; set; }

        [Display(Name = "Extension")]
        public String Extension { get; set; }
    }

    //Detalles
    public class ProductsDetailsViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "CategoryId")]
        public int? CategoryId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public double? Price { get; set; }

        [Display(Name = "ShippingCost")]
        public double? ShippingCost { get; set; }

        [Display(Name = "Warranty")]
        public string Warranty { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }

        [Display(Name = "StateId")]
        public int? StateId { get; set; }

        [Display(Name = "CustomerId")]
        public int? CustomerId { get; set; }

        [Display(Name = "Guid")]
        public String Guid { get; set; }

        [Display(Name = "Extension")]
        public String Extension { get; set; }
    }
}