using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimKk
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Banka { get; set; }

    public string? Sube { get; set; }

    public string? Hesapno { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkilitel { get; set; }

    public string? Muhasebekodu { get; set; }

    public decimal? Limit { get; set; }

    public int? Hesapkesim { get; set; }

    public int? Sonodeme { get; set; }

    public long? LedmuhHesapid { get; set; }
}
