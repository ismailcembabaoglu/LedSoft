using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LrfPrintlayout
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Lrfobjectcode { get; set; }

    public byte[]? Printlayout { get; set; }

    public string? PrintlayoutHash { get; set; }

    public bool? Active { get; set; }
}
