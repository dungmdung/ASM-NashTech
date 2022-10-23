using System.ComponentModel.DataAnnotations;

namespace Assignment10_EFcore.DTOs
{
    public class AddStudentRequest
    {
        [Required]
        public string? FirstName { get; set; }
        
        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? City { get; set; }
        
        [Required]
        public string? State { get; set; }
    }
}