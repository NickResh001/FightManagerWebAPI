using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Setting
{
    public int SettingId { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Scene> Scenes { get; } = new List<Scene>();
}
