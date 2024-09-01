using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PosyazarkasaPlu
{
    public long Id { get; set; }

    public long? Subeid { get; set; }

    public long? Kasaid { get; set; }

    public long? Stokid { get; set; }

    public string? Kod { get; set; }

    public string? Grupkod { get; set; }

    public string? Isim { get; set; }

    public decimal? Kdv { get; set; }

    public string? Kdvdepartman { get; set; }

    public string? Birim { get; set; }

    public string? Birim2 { get; set; }

    public string? Birim3 { get; set; }

    public string? Birim2barkod { get; set; }

    public string? Birim3barkod { get; set; }

    public decimal? Birim2carpan { get; set; }

    public decimal? Birim3carpan { get; set; }

    public string? Barkod { get; set; }

    public string? Tartili { get; set; }

    public int? Pluno { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Fiyat2 { get; set; }

    public decimal? Iskontoyuzde { get; set; }

    public decimal? Iskontomiktar { get; set; }
}
