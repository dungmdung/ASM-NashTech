using System.ComponentModel.DataAnnotations;

namespace Assignment11_EFcore.Data.Entities;

public class Product : BaseEntity<int>
{
    [Required]
    [StringLength(100)]
    public string ProductName { get; set; } = null!;
    [Required]
    [StringLength(50)]
    public string Manufacture { get; set; } = null!;
    [Required]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}