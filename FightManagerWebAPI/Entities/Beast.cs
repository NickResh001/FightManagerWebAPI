using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Beast
{
    public int BeastId { get; set; }

    public int BeastNoteFk { get; set; }

    public int FightTeamFk { get; set; }

    public int CurrentArmorClass { get; set; }

    public string Title { get; set; } = null!;

    public int MaxHitPoint { get; set; }

    public int TemporaryHitPoints { get; set; }

    public string CurrentInitiative { get; set; } = null!;

    public virtual ICollection<ActionResourceList> ActionResourceLists { get; set; } = new List<ActionResourceList>();

    public virtual ICollection<BeastList> BeastLists { get; set; } = new List<BeastList>();

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual ICollection<ConditionList> ConditionLists { get; set; } = new List<ConditionList>();

    public virtual FightTeam FightTeamFkNavigation { get; set; } = null!;

    public virtual ICollection<SpellSlotsList> SpellSlotsLists { get; set; } = new List<SpellSlotsList>();

    public virtual ICollection<TemporaryAbilityList> TemporaryAbilityLists { get; set; } = new List<TemporaryAbilityList>();
}
