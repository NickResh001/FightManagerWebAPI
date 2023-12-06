using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class HabitatList
{
    public int HabitatListId { get; set; }

    public int HabitatFk { get; set; }

    public int BeastNoteFk { get; set; }

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual Habitat HabitatFkNavigation { get; set; } = null!;
}
