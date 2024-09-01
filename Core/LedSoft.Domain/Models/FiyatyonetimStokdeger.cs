using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FiyatyonetimStokdeger
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public decimal? Indirimyuzde { get; set; }

    public decimal? Indirimtutar { get; set; }

    public decimal? Artirimyuzde { get; set; }

    public decimal? Artirimtutar { get; set; }
}
