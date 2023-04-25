using System;
using System.Collections.Generic;

namespace freshCV.Models;

public partial class Education
{
    public string EduId { get; set; } = null!;

    public string? Institution { get; set; }

    public string? Major { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
