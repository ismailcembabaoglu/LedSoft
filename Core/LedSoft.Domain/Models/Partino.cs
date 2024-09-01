using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Partino
{
    public long Id { get; set; }

    public long? Depoid { get; set; }

    public long? Stokid { get; set; }

    public string? Partino1 { get; set; }

    public decimal? Miktar { get; set; }
}
