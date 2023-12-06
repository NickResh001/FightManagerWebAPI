using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class User : IdentityUser
{
    public int? CreatorsTeamFk { get; set; }

    public virtual CreatorsTeam CreatorsTeamFkNavigation { get; set; } = null!;

    public virtual ICollection<Scene> Scenes { get; set; } = new List<Scene>();

    public virtual ICollection<BeastNote> BeastNotes { get; set; } = new List<BeastNote>();
}
