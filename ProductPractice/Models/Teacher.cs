using System;
using System.Collections.Generic;

namespace ProductPractice.Models;

public partial class Teacher
{
    public int TId { get; set; }

    public string TName { get; set; } = null!;

    public string? Subject { get; set; }

    public DateOnly? Doj { get; set; }

    public decimal? Salary { get; set; }

    public int? Workload { get; set; }

    public string? Gender { get; set; }
}
