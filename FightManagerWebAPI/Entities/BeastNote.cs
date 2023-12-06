using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class BeastNote
{
    public int BeastNoteId { get; set; }

    public string HitPointDice { get; set; } = null!;

    public int InitiativeBonus { get; set; }

    public int ArmorClass { get; set; }

    public int SpecialBonus { get; set; }

    public int? SpellingInfoFk { get; set; }

    public byte[] Image { get; set; } = null!;

    public string Title { get; set; } = null!;

    public int AlingmentFk { get; set; }

    public int SizeFk { get; set; }

    public int BeastTypeFk { get; set; }

    public string UserFk { get; set; } = null!;

    public int ChallengeRating { get; set; }

    public string Description { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public DateOnly EditingDate { get; set; }

    public int AllUses { get; set; }

    public int ActualUses { get; set; }

    public virtual ICollection<AbilityList> AbilityLists { get; set; } = new List<AbilityList>();

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();

    public virtual Alignment AlingmentFkNavigation { get; set; } = null!;

    public virtual BeastType BeastTypeFkNavigation { get; set; } = null!;

    public virtual ICollection<Beast> Beasts { get; set; } = new List<Beast>();

    public virtual ICollection<ConditionImmuneList> ConditionImmuneLists { get; set; } = new List<ConditionImmuneList>();

    public virtual ICollection<DamageTendency> DamageTendencies { get; set; } = new List<DamageTendency>();

    public virtual ICollection<HabitatList> HabitatLists { get; set; } = new List<HabitatList>();

    public virtual ICollection<SenseList> SenseLists { get; set; } = new List<SenseList>();

    public virtual Size SizeFkNavigation { get; set; } = null!;

    public virtual ICollection<SkillList> SkillLists { get; set; } = new List<SkillList>();

    public virtual ICollection<SpeedList> SpeedLists { get; set; } = new List<SpeedList>();

    public virtual SpellingInfo? SpellingInfoFkNavigation { get; set; }
    public virtual User UserFkNavigation { get; set; } = null!;

}
