using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wfatura
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public long? Chid { get; set; }

    public long? Depoid { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public long? Temsilciid { get; set; }

    public string? Ozelkod { get; set; }

    public long? Projeid { get; set; }

    public bool? Yazdirildi { get; set; }

    public int? Sevkadresid { get; set; }

    public int? Ziyaretid { get; set; }

    public bool? Proformacarietki { get; set; }

    public bool Iptal { get; set; }

    public decimal? Tutar { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur { get; set; }

    public decimal? Doviztutar { get; set; }

    public int Subeid { get; set; }
}
