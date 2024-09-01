using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimB2bkullanici
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Parola { get; set; }

    public string? Anahtar { get; set; }

    public DateTime? Songiris { get; set; }

    public bool? YetkiEkstre { get; set; }

    public bool? YetkiSiparis { get; set; }

    public bool? YetkiSiparisfiyat { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Depoid { get; set; }

    public string? Isim { get; set; }

    public string? Gsm { get; set; }

    public string? Eposta { get; set; }

    public bool? Aktif { get; set; }

    public bool? YetkiIstegebagliodeme { get; set; }
}
