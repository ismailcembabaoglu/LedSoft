using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjUser
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? Coder { get; set; }

    public bool? Designer { get; set; }

    public string? Decleration { get; set; }

    public string? Projectcode { get; set; }
}
