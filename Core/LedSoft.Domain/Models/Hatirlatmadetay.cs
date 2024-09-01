using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Hatirlatmadetay
{
    public long Id { get; set; }

    public long? Hatirlatmaid { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Tutar { get; set; }
}
