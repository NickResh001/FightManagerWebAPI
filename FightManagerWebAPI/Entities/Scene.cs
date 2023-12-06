using System;
using System.Collections.Generic;

namespace FightManagerWebAPI.Entities;

public partial class Scene
{
    public int SceneId { get; set; }

    public string Title { get; set; } = null!;

    public string UserFk { get; set; } = null!;

    public int SettingFk { get; set; }

    public virtual ICollection<SceneSave> SceneSaves { get; set; } = new List<SceneSave>();

    public virtual Setting SettingFkNavigation { get; set; } = null!;

    public virtual User UserFkNavigation { get; set; } = null!;
}
