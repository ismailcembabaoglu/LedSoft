using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjWmMenu
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Caption { get; set; }

    public string? Module { get; set; }

    public string? Function { get; set; }

    public string? Parentcode { get; set; }

    public string? Imagecode { get; set; }

    public int? Order { get; set; }

    public string? Projectcode { get; set; }
}
