using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Satisdetay
{
    public long Id { get; set; }

    public long? Satisid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Iskonto { get; set; }

    public long? Varyasyonid { get; set; }

    public string? Temsilci { get; set; }

    public long? Satisdanismanid { get; set; }
}
