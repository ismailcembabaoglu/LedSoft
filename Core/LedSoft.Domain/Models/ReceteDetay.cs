using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ReceteDetay
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public long? Uretimbirimid { get; set; }

    public decimal? Uretimbirimcarpan { get; set; }

    public decimal? Yuzde { get; set; }

    public decimal? Miktar { get; set; }

    public long? Receteid { get; set; }

    public long? Depoid { get; set; }
}
