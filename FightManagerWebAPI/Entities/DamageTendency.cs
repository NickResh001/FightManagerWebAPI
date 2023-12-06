using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class DamageTendency
{
    public int DamageTendencyId { get; set; }

    public int DamageTypeFk { get; set; }

    public int DamageTendencyTypeFk { get; set; }

    public int BeastNoteFk { get; set; }

    public bool Magical { get; set; }

    public bool NonMagical { get; set; }

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual DamageTendencyType DamageTendencyTypeFkNavigation { get; set; } = null!;

    public virtual DamageType DamageTypeFkNavigation { get; set; } = null!;
}
