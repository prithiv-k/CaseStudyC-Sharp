using System.ComponentModel.DataAnnotations;

namespace CaseStudy_LayoutView.Models
{
    public enum UserRole
    {
        Admin,
        Trainer,
        Learner
    }
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public UserRole Role { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
