using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimVaryasyon
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Aciklama { get; set; }

    public long? Stokid { get; set; }

    public virtual Stoktanim? Stok { get; set; }
}
