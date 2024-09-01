using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class UsersMenu
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? Menuitemcode { get; set; }

    public bool? Show { get; set; }
}
