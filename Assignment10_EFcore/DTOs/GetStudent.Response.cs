namespace Assignment10_EFcore.DTOs
{
    public class GetStudentResponse
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? City { get; set; }
        
        public string? State { get; set; }
    }
}