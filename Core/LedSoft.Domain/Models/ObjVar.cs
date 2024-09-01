using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjVar
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Defaultvalue { get; set; }

    public short? Type { get; set; }

    public string? Items { get; set; }

    public string? Parent { get; set; }

    public int? Ord { get; set; }

    public int? Parentid { get; set; }

    public string? Projectcode { get; set; }
}
