using System.ComponentModel.DataAnnotations;

namespace CaseStudy_LayoutView.Models
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        [Display(Name = "Content URL")]
        public string ContentUrl { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
