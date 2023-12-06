using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class DamageType
{
    public int DamageTypeId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<DamageTendency> DamageTendencies { get; set; } = new List<DamageTendency>();
}
