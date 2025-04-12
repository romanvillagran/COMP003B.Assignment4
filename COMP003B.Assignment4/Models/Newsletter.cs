using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    
        public class Newsletter
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Please enter your name")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Please enter your email")]
            [EmailAddress(ErrorMessage = "Invalid email address")]
            public string Email { get; set; }
        }
    
}
