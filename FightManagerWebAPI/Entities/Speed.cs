using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Speed
{
    public int SpeedId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<SpeedList> SpeedLists { get; set; } = new List<SpeedList>();
}
