using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimHizmetkdv
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public decimal? Kdvyuzde { get; set; }

    public string? Satiskdvkod { get; set; }

    public string? Indirilecekkdv { get; set; }
}
