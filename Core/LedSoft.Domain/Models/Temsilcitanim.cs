using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Temsilcitanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public bool? Aktif { get; set; }

    public bool? Terminalvar { get; set; }

    public int? Subeid { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Tckimlikno { get; set; }

    public string? Aracplakano { get; set; }

    public string? Entegrasyonkod { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Sifre { get; set; }

    public string? Gsm { get; set; }

    public string? Eposta { get; set; }
}
