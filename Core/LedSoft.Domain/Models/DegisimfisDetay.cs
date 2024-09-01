using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DegisimfisDetay
{
    public long Id { get; set; }

    public long? Degisimfisid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public long? Iadesebepid { get; set; }

    public string? Partino { get; set; }

    public string? Degisimpartino { get; set; }
}
