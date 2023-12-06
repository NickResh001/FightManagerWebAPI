using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Skill
{
    public int SkillId { get; set; }

    public int AbilityFk { get; set; }

    public string Title { get; set; } = null!;

    public virtual Ability AbilityFkNavigation { get; set; } = null!;

    public virtual ICollection<SkillList> SkillLists { get; set; } = new List<SkillList>();
}
