using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SpellSlot
{
    public int SpellSlotId { get; set; }

    public int SpellingInfoFk { get; set; }

    public int SlotLevel { get; set; }

    public int Count { get; set; }

    public virtual SpellingInfo SpellingInfoFkNavigation { get; set; } = null!;
}
