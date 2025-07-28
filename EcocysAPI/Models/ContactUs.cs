using System.ComponentModel.DataAnnotations;

namespace EcocysAPI.Models
{
    public class ContactUs
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string CompanyName { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Required, Phone, StringLength(10)]
        public string ContactNumber { get; set; }

        [Required, StringLength(250)]
        public string Address { get; set; }

        [Required]
        public string BusinessType { get; set; }

        [Required]
        public string ProductShoot { get; set; }

        [Required]
        public string SellOnline { get; set; }

        public string ProblemStatement { get; set; }
    }
}
