using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Whatirlatmalar
{
    public long Id { get; set; }

    public string? Surucuadsoyad { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Marka { get; set; }

    public string? Model { get; set; }

    public string? Tip { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Kalan { get; set; }

    public string? Renk { get; set; }

    public DateTime? SonrakiTarih { get; set; }

    public int? SonrakiKm { get; set; }
}
