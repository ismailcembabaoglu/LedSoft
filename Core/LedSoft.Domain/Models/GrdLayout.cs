using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class GrdLayout
{
    public long Id { get; set; }

    public string? Objecttype { get; set; }

    public string? Objectcode { get; set; }

    public string? Gridname { get; set; }

    public string? Name { get; set; }

    public long? Userid { get; set; }

    public string? Layoutxml { get; set; }

    public string? Layoutxmlhash { get; set; }
}
