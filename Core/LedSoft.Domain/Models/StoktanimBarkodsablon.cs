using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimBarkodsablon
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public bool? Aktif { get; set; }

    public int? Kodbaslangic { get; set; }

    public int? Kodgenislik { get; set; }

    public bool? Miktarkullan { get; set; }

    public int? Miktarbaslangic { get; set; }

    public int? Miktargenislik { get; set; }

    public decimal? Miktarcarpan { get; set; }

    public bool? Fiyatkullan { get; set; }

    public int? Fiyatbaslangic { get; set; }

    public int? Fiyatgenislik { get; set; }

    public bool? Partinokullan { get; set; }

    public int? Partinobaslangic { get; set; }

    public int? Partinogenislik { get; set; }

    public bool? Serinokullan { get; set; }

    public int? Serinobaslangic { get; set; }

    public int? Serinogenislik { get; set; }

    public bool? Sktkullan { get; set; }

    public int? Sktbaslangic { get; set; }

    public int? Sktgenislik { get; set; }

    public string? Sktbicim { get; set; }

    public bool? Ambalajmiktarkullan { get; set; }

    public int? Ambalajmiktarbaslangic { get; set; }

    public int? Ambalajmiktargenislik { get; set; }
}
