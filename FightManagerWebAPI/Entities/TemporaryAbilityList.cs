using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class TemporaryAbilityList
{
    public int TemporaryAbilityListId { get; set; }

    public int BeastFk { get; set; }

    public int AbilityFk { get; set; }

    public int Value { get; set; }

    public bool SavingThrowProficiency { get; set; }

    public virtual Ability AbilityFkNavigation { get; set; } = null!;

    public virtual Beast BeastFkNavigation { get; set; } = null!;
}
