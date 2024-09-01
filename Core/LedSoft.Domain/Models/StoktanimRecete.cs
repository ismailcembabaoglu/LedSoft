using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimRecete
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public long? Recetestokid { get; set; }

    public decimal? Miktar { get; set; }

    public long? Birimid { get; set; }
}
