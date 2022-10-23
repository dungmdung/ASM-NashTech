using System.ComponentModel.DataAnnotations;

namespace Assignment11_EFcore.Data.Entities;

public class Category : BaseEntity<int>
{
    [Required]
    [StringLength(100)]
    public string CategoryName { get; set; } = null!;
    public ICollection<Product> Products { get; set; } = null!;
}