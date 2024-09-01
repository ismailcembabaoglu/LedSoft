using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjDb
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Scriptcode { get; set; }

    public string? Projectcode { get; set; }

    public int? Ord { get; set; }

    public string? Scriptcodexml { get; set; }
}
