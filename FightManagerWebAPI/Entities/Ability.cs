using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Ability
{
    public int AbilityId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<AbilityList> AbilityLists { get; set; } = new List<AbilityList>();

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();

    public virtual ICollection<SpellingInfo> SpellingInfos { get; set; } = new List<SpellingInfo>();

    public virtual ICollection<TemporaryAbilityList> TemporaryAbilityLists { get; set; } = new List<TemporaryAbilityList>();
}
