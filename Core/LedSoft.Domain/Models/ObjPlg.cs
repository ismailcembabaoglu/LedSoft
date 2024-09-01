using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjPlg
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public byte[]? Dll { get; set; }

    public string? DllHash { get; set; }

    public string? DllName { get; set; }

    public bool? Active { get; set; }

    public string? Projectcode { get; set; }

    public DateTime? Modifydatetime { get; set; }
}
