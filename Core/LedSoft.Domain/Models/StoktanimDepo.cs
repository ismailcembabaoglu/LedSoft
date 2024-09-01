using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimDepo
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public long? Depoid { get; set; }

    public decimal? Minmiktar { get; set; }

    public decimal? Uygunmiktar { get; set; }

    public decimal? Maxmiktar { get; set; }
}
