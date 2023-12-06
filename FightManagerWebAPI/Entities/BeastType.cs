using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class BeastType
{
    public int BeastTypeId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<BeastNote> BeastNotes { get; set; } = new List<BeastNote>();
}
