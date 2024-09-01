using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SatisteklifDetay
{
    public long Id { get; set; }

    public long? Satisteklifid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Fiyat { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Gramaj { get; set; }

    public string? Gramajbirim { get; set; }

    public decimal? Brutgramaj { get; set; }

    public string? Brutgramajbirim { get; set; }

    public decimal? Hacim { get; set; }

    public string? Hacimbirim { get; set; }

    public string? Barkod { get; set; }

    public string? Gtipno { get; set; }
}
