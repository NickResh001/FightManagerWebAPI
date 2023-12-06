using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class AbilityList
{
    public int AbilityListId { get; set; }

    public int AbilityFk { get; set; }

    public int BeastNoteFk { get; set; }

    public int Value { get; set; }

    public bool SavingThrowProficiency { get; set; }

    public virtual Ability AbilityFkNavigation { get; set; } = null!;

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;
}
