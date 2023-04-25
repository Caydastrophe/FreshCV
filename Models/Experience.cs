using System;
using System.Collections.Generic;

namespace freshCV.Models;

public partial class Experience
{
    public string ExpId { get; set; } = null!;

    public string? JobTitle { get; set; }

    public string? Employer { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
