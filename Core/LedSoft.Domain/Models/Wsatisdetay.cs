using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wsatisdetay
{
    public long Faturaid { get; set; }

    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public string? Aciklama { get; set; }

    public long? Depoid { get; set; }

    public long? Chid { get; set; }

    public long? Stokid { get; set; }

    public int Sevkadresid { get; set; }

    public int Subeid { get; set; }

    public long Temsilciid { get; set; }

    public decimal? Netsatismiktar { get; set; }

    public decimal? Netsatisfiyat { get; set; }

    public decimal? Satisfiyat { get; set; }

    public long Projeid { get; set; }

    public string? Harozelkod { get; set; }
}
