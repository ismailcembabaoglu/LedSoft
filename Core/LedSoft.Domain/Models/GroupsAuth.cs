using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class GroupsAuth
{
    public int Id { get; set; }

    public int? Groupid { get; set; }

    public int? Authorityid { get; set; }

    public string? Value { get; set; }

    public string? Authoritycode { get; set; }
}
