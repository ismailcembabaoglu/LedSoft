using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SayimDetay
{
    public long Id { get; set; }

    public long? Sayimid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birimid { get; set; }

    public int? Ambalajbirimid { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Fiyat { get; set; }

    public long? Varyasyonid { get; set; }

    public DateTime? Skt { get; set; }
}
