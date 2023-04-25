using System;
using System.Collections.Generic;

namespace freshCV.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }

    public virtual ICollection<Education> Educations { get; } = new List<Education>();

    public virtual ICollection<Experience> Experiences { get; } = new List<Experience>();

    public virtual ICollection<ReferencesTable> ReferencesTables { get; } = new List<ReferencesTable>();

    public virtual ICollection<Skill> Skills { get; } = new List<Skill>();
}
