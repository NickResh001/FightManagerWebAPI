using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SpellingInfo
{
    public int SpellingInfoId { get; set; }

    public int SpellAbilityFk { get; set; }

    public int SaveThrowDifficulty { get; set; }

    public int AttackBonus { get; set; }

    public virtual ICollection<BeastNote> BeastNotes { get; set; } = new List<BeastNote>();

    public virtual Ability SpellAbilityFkNavigation { get; set; } = null!;

    public virtual ICollection<SpellSlot> SpellSlots { get; set; } = new List<SpellSlot>();
}
