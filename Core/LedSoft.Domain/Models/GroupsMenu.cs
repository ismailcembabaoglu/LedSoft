using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class GroupsMenu
{
    public int Id { get; set; }

    public int? Groupid { get; set; }

    public string? Menuitemcode { get; set; }

    public bool? Show { get; set; }
}
