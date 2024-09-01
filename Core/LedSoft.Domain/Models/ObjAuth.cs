using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjAuth
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Defaultvalue { get; set; }

    public short? Type { get; set; }

    public string? Items { get; set; }

    public long? Parentid { get; set; }

    public int? Ord { get; set; }

    public string? Parent { get; set; }

    public string? Projectcode { get; set; }
}
