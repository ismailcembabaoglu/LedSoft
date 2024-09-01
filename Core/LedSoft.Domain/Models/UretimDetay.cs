using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class UretimDetay
{
    public long Id { get; set; }

    public long? Uretimid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Recetemiktar { get; set; }

    public decimal? Recetemiktaryuzde { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Carpan { get; set; }

    public long? Depoid { get; set; }
}
