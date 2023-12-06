using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Sense
{
    public int SenseId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<SenseList> SenseLists { get; set; } = new List<SenseList>();
}
