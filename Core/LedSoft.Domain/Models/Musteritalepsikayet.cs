using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Musteritalepsikayet
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Isim { get; set; }

    public string? Telefon { get; set; }

    public string? Eposta { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonuc { get; set; }

    public bool? Kapali { get; set; }

    public string? Sorumlu { get; set; }

    public long? Subeid { get; set; }
}
