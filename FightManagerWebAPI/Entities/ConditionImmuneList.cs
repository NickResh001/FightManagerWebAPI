using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class ConditionImmuneList
{
    public int ConditionImmuneListId { get; set; }

    public int ConditionFk { get; set; }

    public int BeastNoteFk { get; set; }

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual Condition ConditionFkNavigation { get; set; } = null!;
}
