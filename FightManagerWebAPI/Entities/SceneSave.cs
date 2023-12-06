using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class SceneSave
{
    public int SceneSaveId { get; set; }

    public DateOnly CreationDate { get; set; }

    public string Title { get; set; } = null!;

    public int SceneFk { get; set; }

    public string CurrentBeastInitiative { get; set; } = null!;

    public virtual ICollection<BeastList> BeastLists { get; set; } = new List<BeastList>();

    public virtual Scene SceneFkNavigation { get; set; } = null!;
}
