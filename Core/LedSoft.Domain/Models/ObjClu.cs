using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjClu
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? Locked { get; set; }

    public bool? Systemlocked { get; set; }

    public string? Data { get; set; }

    public string? Projectcode { get; set; }
}
