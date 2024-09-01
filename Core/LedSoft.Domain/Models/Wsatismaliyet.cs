using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wsatismaliyet
{
    public long Uretimid { get; set; }

    public long Faturaid { get; set; }

    public long Depotransferid { get; set; }

    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public long? Stokid { get; set; }

    public long? Subeid { get; set; }

    public long? Projeid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Satisfiyat { get; set; }

    public decimal? Birimekmaliyet { get; set; }
}
