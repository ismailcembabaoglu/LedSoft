using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PropLaf
{
    public int Id { get; set; }

    public string? Lafobjectcode { get; set; }

    public long? Recordid { get; set; }

    public int? Updatecount { get; set; }

    public bool? Locked { get; set; }

    public string? Declaration { get; set; }
}
