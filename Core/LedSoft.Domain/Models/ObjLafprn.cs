using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjLafprn
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Lafobjectcode { get; set; }

    public byte[]? Printlayout { get; set; }

    public string? PrintlayoutHash { get; set; }

    public bool? Active { get; set; }

    public bool? Show { get; set; }

    public string? Projectcode { get; set; }
}
