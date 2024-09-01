using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Printlayout
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Lafobjectcode { get; set; }

    public byte[]? Printlayout1 { get; set; }

    public string? PrintlayoutHash { get; set; }

    public bool? Active { get; set; }

    public bool? Textmode { get; set; }

    public string? Designmode { get; set; }

    public byte[]? Printlayoutfr3 { get; set; }

    public string? Printlayoutfr3Hash { get; set; }

    public string? Users { get; set; }
}
