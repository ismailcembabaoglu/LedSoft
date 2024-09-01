using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class KampanyaSonucdetay
{
    public long Id { get; set; }

    public long? Kampanyaid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public decimal? Iskonto3 { get; set; }
}
