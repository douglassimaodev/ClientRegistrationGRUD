using System.ComponentModel.DataAnnotations;

namespace ClientRegistration.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Date of birthday")]
        public DateTime DateOfBirthday { get; set; }

        public virtual Address Address { get; set; }

    }
}