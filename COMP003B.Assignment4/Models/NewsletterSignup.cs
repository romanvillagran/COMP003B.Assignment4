using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class NewsletterSignup
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
