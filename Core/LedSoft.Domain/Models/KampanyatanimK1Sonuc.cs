using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class KampanyatanimK1Sonuc
{
    public long Id { get; set; }

    public long? Kampanyaid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Fiyat { get; set; }
}
