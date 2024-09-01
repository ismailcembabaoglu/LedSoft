using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Recete
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public bool? Aktif { get; set; }

    public int? Girenfiyatlisteid { get; set; }

    public int? Cikanfiyatlisteid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Birimcarpan { get; set; }

    public long? Uretimbirimid { get; set; }

    public decimal? Uretimbirimcarpan { get; set; }

    public decimal? Uretimbirimmiktartoplam { get; set; }
}
