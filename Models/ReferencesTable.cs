using System;
using System.Collections.Generic;

namespace freshCV.Models;

public partial class ReferencesTable
{
    public string RefId { get; set; } = null!;

    public string? EmployerName { get; set; }

    public string? EmpRole { get; set; }

    public string? Company { get; set; }

    public string? Email { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
