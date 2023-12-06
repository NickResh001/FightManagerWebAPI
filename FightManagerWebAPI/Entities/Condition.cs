using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Condition
{
    public int ConditionId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<ConditionImmuneList> ConditionImmuneLists { get; set; } = new List<ConditionImmuneList>();

    public virtual ICollection<ConditionList> ConditionLists { get; set; } = new List<ConditionList>();
}
