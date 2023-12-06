using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SenseList
{
    public int SenseListId { get; set; }

    public int SenseFk { get; set; }

    public int BeastNoteFk { get; set; }

    public int DistanceInFeet { get; set; }

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual Sense SenseFkNavigation { get; set; } = null!;
}
