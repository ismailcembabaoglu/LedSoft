using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Mutabakatdetay
{
    public long Id { get; set; }

    public long? Mutabakatid { get; set; }

    public long? Chid { get; set; }

    public decimal? Tutar { get; set; }

    public int? Faturaadet { get; set; }

    public decimal? Matrah { get; set; }

    public decimal? Kdv { get; set; }

    public byte[]? Gorsel1 { get; set; }

    public byte[]? Gorsel2 { get; set; }

    public string? Onay { get; set; }

    public bool? Smsgonderildi { get; set; }
}
