using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Alignment
{
    public int AlignmentId { get; set; }

    public int Law { get; set; }

    public int Goodness { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<BeastNote> BeastNotes { get; set; } = new List<BeastNote>();
}
