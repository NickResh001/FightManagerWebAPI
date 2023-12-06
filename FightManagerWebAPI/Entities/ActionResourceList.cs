using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class ActionResourceList
{
    public int ActionResourceListId { get; set; }

    public int BeastFk { get; set; }

    public int ActionResourceFk { get; set; }

    public bool Available { get; set; }

    public virtual ActionResource ActionResourceFkNavigation { get; set; } = null!;

    public virtual Beast BeastFkNavigation { get; set; } = null!;
}
