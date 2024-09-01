using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class WraporSiparisliste
{
    public long Id { get; set; }

    public long Chid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Evrakseri { get; set; }

    public string? Evraksira { get; set; }

    public string? Evrakno { get; set; }

    public string? Chkod { get; set; }

    public string? Chisim { get; set; }

    public string? Depokod { get; set; }

    public string? Depoisim { get; set; }

    public decimal? Siparismiktar { get; set; }

    public decimal? Matrah { get; set; }

    public decimal? Kdv { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur { get; set; }

    public decimal? Tutar { get; set; }

    public bool? Durum { get; set; }
}
