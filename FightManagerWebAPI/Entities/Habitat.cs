using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Habitat
{
    public int HabitatId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<HabitatList> HabitatLists { get; set; } = new List<HabitatList>();
}
