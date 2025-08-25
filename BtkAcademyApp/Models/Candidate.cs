using System.ComponentModel.DataAnnotations;

namespace BtkAcademyApp.Models
{
    public class Candidate
    {

        [Required (ErrorMessage ="e-mail is required")]
        public string? Email { get; set; } = string.Empty;
          [Required (ErrorMessage ="first name is required")]
        public string? FirstName { get; set; } = string.Empty;
        
          [Required(ErrorMessage = "last-name is required")]
        public string? LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = string.Empty;

        public DateTime ApplyAt { get; set; }
        
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}