using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimBirimcevrim
{
    public long Id { get; set; }

    public int? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }
}
