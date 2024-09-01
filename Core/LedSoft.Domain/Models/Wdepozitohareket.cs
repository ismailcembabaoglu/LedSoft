using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wdepozitohareket
{
    public long Faturaid { get; set; }

    public long? Depoid { get; set; }

    public long? Chid { get; set; }

    public int? Sevkadresid { get; set; }

    public DateTime? Tarih { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Miktar { get; set; }
}
