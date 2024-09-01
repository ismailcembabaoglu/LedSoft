using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class WraporSiparislistedetay
{
    public long Id { get; set; }

    public long Stokid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Birim { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public decimal? Iskonto3 { get; set; }

    public decimal? Iskonto4 { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Sevkmiktar { get; set; }

    public decimal? Kalanmiktar { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? Toplamtutar { get; set; }
}
