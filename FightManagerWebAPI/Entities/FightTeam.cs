using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class FightTeam
{
    public int FightTeamId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Beast> Beasts { get; set; } = new List<Beast>();
}
