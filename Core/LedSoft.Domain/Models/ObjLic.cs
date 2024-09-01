using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjLic
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Value { get; set; }

    public string? Grp { get; set; }
}
