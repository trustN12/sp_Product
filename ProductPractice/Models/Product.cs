using System.ComponentModel.DataAnnotations;

namespace ProductPractice.Models;

public class Product
{
    public int ProductID { get; set; }

    [Required]
    [MaxLength(100)]
    public string ProductName { get; set; }
    
    [MaxLength(50)]
    public string Category { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public DateTime CreatedDate { get; set; }
}