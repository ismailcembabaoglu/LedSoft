using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimP
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public long? Bankaid { get; set; }

    public string? Banka { get; set; }

    public string? Sube { get; set; }

    public string? Hesapno { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkilitel { get; set; }

    public string? Muhasebekodu { get; set; }

    public int? Gelirgiderid { get; set; }

    public long? LedmuhHesapid { get; set; }

    public string? Entegrasyonkod { get; set; }

    public bool? Sanalpos { get; set; }

    public string? SanalposKullaniciadi { get; set; }

    public string? SanalposSifre { get; set; }

    public string? SanalposLink { get; set; }
}
