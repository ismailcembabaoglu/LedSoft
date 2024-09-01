using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimKoddonusumDetay
{
    public long Id { get; set; }

    public long? Urunanlasmaid { get; set; }

    public long? Stokid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }
}
