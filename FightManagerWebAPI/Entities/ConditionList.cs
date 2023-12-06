using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class ConditionList
{
    public int ConditionListId { get; set; }

    public int BeastFk { get; set; }

    public int ConditionFk { get; set; }

    public int? RoundCount { get; set; }

    public virtual Beast BeastFkNavigation { get; set; } = null!;

    public virtual Condition ConditionFkNavigation { get; set; } = null!;
}
