using System.ComponentModel.DataAnnotations;

namespace Assignment10_EFcore.DTOs
{
    public class UpdateStudentRequest
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } 

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } 

        [Required]
        public string City { get; set; } 
        
        [Required]
        public string State { get; set; } 
    }
}