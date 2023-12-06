using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class ActionResource
{
    public int ActionResourceId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<ActionResourceList> ActionResourceLists { get; set; } = new List<ActionResourceList>();

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();
}
