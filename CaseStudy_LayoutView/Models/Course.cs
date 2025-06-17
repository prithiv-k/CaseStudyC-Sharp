using System.ComponentModel.DataAnnotations;

namespace CaseStudy_LayoutView.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Duration (Hours)")]
        public int Duration { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
