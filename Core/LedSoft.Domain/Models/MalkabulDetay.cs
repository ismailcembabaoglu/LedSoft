using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class MalkabulDetay
{
    public long Id { get; set; }

    public long? Malkabulid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Miktar { get; set; }

    public long? Ambalajbirimid { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public decimal? Carpan { get; set; }

    public DateTime? Skt { get; set; }

    public long? Varyasyonid { get; set; }
}
