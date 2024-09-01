using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Kasaesitleme
{
    public long Id { get; set; }

    public long? Subeid { get; set; }

    public long? Kasaid { get; set; }

    public long? Stokid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public decimal? Kdv { get; set; }

    public string? Birim { get; set; }

    public long? Birimid { get; set; }

    public string? Barkod { get; set; }

    public decimal? Carpan { get; set; }

    public int? BKl { get; set; }

    public int? BKw { get; set; }

    public bool? BM { get; set; }

    public int? BMl { get; set; }

    public int? BMw { get; set; }

    public decimal? BMc { get; set; }

    public bool? Goster { get; set; }

    public bool? Terazi { get; set; }

    public string? Grup { get; set; }

    public int? Sira { get; set; }

    public int? Plu { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Maxisk { get; set; }

    public string? KIsim { get; set; }

    public string? YDk { get; set; }

    public bool? Terazigonder { get; set; }

    public string? Veresiyeiskontotip { get; set; }

    public decimal? Veresiyeiskontooran { get; set; }

    public string? Veresiyeiskontostr { get; set; }

    public string? Varyasyon { get; set; }

    public decimal? BC { get; set; }

    public decimal? Sfiyat { get; set; }

    public long? Varyasyonid { get; set; }
}
