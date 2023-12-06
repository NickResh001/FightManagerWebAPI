using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SkillList
{
    public int SkillListId { get; set; }

    public int SkillFk { get; set; }

    public int BeastNoteFk { get; set; }

    public int Value { get; set; }

    public bool Proficiency { get; set; }

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual Skill SkillFkNavigation { get; set; } = null!;
}
