using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FaturaIhracat
{
    public long Id { get; set; }

    public long? Faturaid { get; set; }

    public string? Teslimsekli { get; set; }

    public string? Odemesekli { get; set; }

    public string? Aracibanka { get; set; }

    public string? Mensei { get; set; }

    public string? Plaka { get; set; }

    public string? Yukleme { get; set; }

    public decimal? Navlunbedel { get; set; }

    public decimal? Fobtutar { get; set; }

    public decimal? Sigortabedel { get; set; }

    public decimal? Brutagirlik { get; set; }

    public decimal? Netagirlik { get; set; }

    public string? Muhurno { get; set; }

    public string? Tasima { get; set; }

    public string? Kapcins { get; set; }

    public string? Kapno { get; set; }

    public int? Kapadet { get; set; }

    public bool? Efaturadovizcevrimkullan { get; set; }

    public string? NavlunbedelDovizcinsi { get; set; }

    public string? Konteynerno { get; set; }
}
