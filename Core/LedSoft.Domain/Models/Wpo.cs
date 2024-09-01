using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wpo
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkilitel { get; set; }

    public string? Hesapno { get; set; }

    public string? Banka { get; set; }

    public string? Sube { get; set; }

    public string? Muhasebekodu { get; set; }

    public bool? Aktif { get; set; }

    public string? SanalposLink { get; set; }

    public int Subeid { get; set; }

    public bool Sanalpos { get; set; }
}
