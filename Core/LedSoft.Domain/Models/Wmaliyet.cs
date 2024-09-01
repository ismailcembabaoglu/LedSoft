using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wmaliyet
{
    public long Uretimid { get; set; }

    public long Faturaid { get; set; }

    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }
}
