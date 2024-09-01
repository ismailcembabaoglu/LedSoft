using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ReceteKalemgiris
{
    public long Id { get; set; }

    public int? Receteid { get; set; }

    public int? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public long? Birimid { get; set; }
}
