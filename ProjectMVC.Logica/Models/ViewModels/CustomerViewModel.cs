using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.ViewModels
{
    public class CustomerDetailsViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public string UserId { get; set; }
    }
}
