using System.ComponentModel.DataAnnotations;

namespace CustomerRegistrationApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required ,StringLength(100)]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

    }
}
