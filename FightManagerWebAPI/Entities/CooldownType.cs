using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class CooldownType
{
    public int CooldownTypeId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();
}
