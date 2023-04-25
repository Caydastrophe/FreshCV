using System;
using System.Collections.Generic;

namespace freshCV.Models;

public partial class Skill
{
    public string SkillId { get; set; } = null!;

    public string? SkillType { get; set; }

    public string? SkillDesc { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
