using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductPractice.Models;

public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Category { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? CreatedDate { get; set; }
}
