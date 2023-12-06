using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SpellSlotsList
{
    public int SpellSlotsListId { get; set; }

    public int BeastFk { get; set; }

    public int SlotLevel { get; set; }

    public bool CountAvailable { get; set; }

    public virtual Beast BeastFkNavigation { get; set; } = null!;
}
