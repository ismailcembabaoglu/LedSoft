using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimBarkod
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public string? Barkod { get; set; }

    public long? Birimid { get; set; }

    public long? Sablonid { get; set; }

    public decimal? Carpan { get; set; }

    public int? Ambalajbirimid { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public bool? Esikdegerkullan { get; set; }

    public long? Varyasyonid { get; set; }
}
