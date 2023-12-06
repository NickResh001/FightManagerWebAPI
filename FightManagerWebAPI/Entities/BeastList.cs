using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class BeastList
{
    public int BeastListId { get; set; }

    public int SceneSaveFk { get; set; }

    public int BeastFk { get; set; }

    public virtual Beast BeastFkNavigation { get; set; } = null!;

    public virtual SceneSave SceneSaveFkNavigation { get; set; } = null!;
}
