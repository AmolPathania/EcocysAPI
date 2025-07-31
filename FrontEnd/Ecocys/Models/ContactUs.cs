using System.ComponentModel.DataAnnotations;

namespace Ecocys.Models
{
    public class ContactUs
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please select a business type")]
        public string BusinessType { get; set; }

        [Required(ErrorMessage = "Please select product shoot option")]
        public string ProductShoot { get; set; }

        [Required(ErrorMessage = "Please select online selling option")]
        public string SellOnline { get; set; }

        [Required(ErrorMessage = "Please describe your problem")]
        public string ProblemStatement { get; set; }
    }
}
