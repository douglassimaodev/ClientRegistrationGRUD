using System.ComponentModel.DataAnnotations;

namespace ClientRegistration.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "Address line 3")]
        public string AddressLine3 { get; set; }

        public virtual Client Client { get; set; }
    }
}
