using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class CreatorsTeam
{
    public int CreatorsTeamId { get; set; }

    public string Title { get; set; } = null!;

    public bool IsCommunityCreators { get; set; }
}
