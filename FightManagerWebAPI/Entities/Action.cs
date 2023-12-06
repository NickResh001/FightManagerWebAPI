using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Action
{
    public int ActionId { get; set; }

    public int BeastNoteFk { get; set; }

    public string Title { get; set; } = null!;

    public int CooldownTypeFk { get; set; }

    public int? Cooldown1ShellSlotLevel { get; set; }

    public int? Cooldown2LowerRangeLimit { get; set; }

    public int? Cooldown2UpperRangeLimit { get; set; }

    public int? Cooldown2DiceSize { get; set; }

    public int? Cooldown3HowManyTimes { get; set; }

    public int? Cooldown3TimeMeasureFk { get; set; }

    public int? Cooldown3MeasureMultiply { get; set; }

    public int ActionResourceFk { get; set; }

    public string? ReactionCondition { get; set; }

    public int? LairInitiativeBonus { get; set; }

    public string Description { get; set; } = null!;

    public int? ParentMultiactionFk { get; set; }

    public bool IsTemplate { get; set; }

    public virtual ActionResource ActionResourceFkNavigation { get; set; } = null!;

    public virtual BeastNote BeastNoteFkNavigation { get; set; } = null!;

    public virtual TimeMeasure? Cooldown3TimeMeasureFkNavigation { get; set; }

    public virtual CooldownType CooldownTypeFkNavigation { get; set; } = null!;
}
