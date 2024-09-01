using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Musteri
{
    public long Id { get; set; }

    public string? Isim { get; set; }

    public string? Adres { get; set; }

    public string? Kartid { get; set; }

    public string? Pin { get; set; }

    public string? Gsm { get; set; }

    public byte[]? Fotograf { get; set; }

    public bool? VeresiyeKullan { get; set; }

    public decimal? VeresiyeUyarilimit { get; set; }

    public decimal? VeresiyeKredilimit { get; set; }

    public int? VeresiyeVadegun { get; set; }

    public string? Kasiyerbilgimesaj { get; set; }

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Eposta { get; set; }

    public string? Grup { get; set; }

    public long? Sorumlusubeid { get; set; }

    public DateTime? Kayittarih { get; set; }

    public string? Entegrasyonkod { get; set; }

    public string? Iskontotip { get; set; }

    public decimal? Iskonto { get; set; }

    public string? AcikhesapKullan { get; set; }
}
