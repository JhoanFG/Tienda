using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    //Crear
    public class ProductsCreateBindingModel
    {
        [Required(ErrorMessage = "The field Category Id is required")]
        [Display(Name = "CategoryId")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Price is required")]
        [Display(Name = "Price")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "The field Shipping Cost is required")]
        [Display(Name = "ShippingCost")]
        public double? ShippingCost { get; set; }

        [Required(ErrorMessage = "The field Warranty is required")]
        [Display(Name = "Warranty")]
        public string Warranty { get; set; }

        [Required(ErrorMessage = "The field Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field Quantity is required")]
        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "The field State Id is required")]
        [Display(Name = "StateId")]
        public int? StateId { get; set; }

        [Required(ErrorMessage = "The field Customer Id is required")]
        [Display(Name = "CustomerId")]
        public int? CustomerId { get; set; }

        [Required(ErrorMessage = "The field Guid is required")]
        [Display(Name = "Guid")]
        public String Guid { get; set; }

        [Required(ErrorMessage = "The field Extension is required")]
        [Display(Name = "Extension")]
        public String Extension { get; set; }
    }

    //Editar
    public class ProductsEditBindingModel
    {
        [Required(ErrorMessage = "The field Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Category Id is required")]
        [Display(Name = "CategoryId")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Price is required")]
        [Display(Name = "Price")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "The field Shipping Cost is required")]
        [Display(Name = "ShippingCost")]
        public double? ShippingCost { get; set; }

        [Required(ErrorMessage = "The field Warranty is required")]
        [Display(Name = "Warranty")]
        public string Warranty { get; set; }

        [Required(ErrorMessage = "The field Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field Quantity is required")]
        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "The field State Id is required")]
        [Display(Name = "StateId")]
        public int? StateId { get; set; }

        [Required(ErrorMessage = "The field Customer Id is required")]
        [Display(Name = "CustomerId")]
        public int? CustomerId { get; set; }

        [Required(ErrorMessage = "The field Guid is required")]
        [Display(Name = "Guid")]
        public String Guid { get; set; }

        [Required(ErrorMessage = "The field Extension is required")]
        [Display(Name = "Extension")]
        public String Extension { get; set; }
    }

    //Detalles
    public class ProductsDetailsBindingModel
    {

    }

    //Eliminar
    public class ProductsDeleteBindingModel
    {

    }
}