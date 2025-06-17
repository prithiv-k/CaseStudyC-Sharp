using System.ComponentModel.DataAnnotations;

namespace CaseStudy_LayoutView.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UserRole Role { get; set; }
    }
}
