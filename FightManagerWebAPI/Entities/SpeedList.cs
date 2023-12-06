using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SpeedList
{
    public int SpeedListId { get; set; }

    public int SpeedFk { get; set; }

    public int BeastNoteFk { get; set; }

    public int DistanceInFeer { get; set; }

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual Speed SpeedFkNavigation { get; set; } = null!;
}
