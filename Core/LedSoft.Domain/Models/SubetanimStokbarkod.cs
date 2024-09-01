using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SubetanimStokbarkod
{
    public long Id { get; set; }

    public long? Subeid { get; set; }

    public long? Stokid { get; set; }

    public string? Barkod { get; set; }
}
