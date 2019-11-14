//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.ProductPhotos = new HashSet<ProductPhotos>();
            this.SaleDetails = new HashSet<SaleDetails>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Name { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> ShippingCost { get; set; }
        public string Warranty { get; set; }
        public string Description { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> CustomerId { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPhotos> ProductPhotos { get; set; }
        public virtual States States { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleDetails> SaleDetails { get; set; }
    }
}
