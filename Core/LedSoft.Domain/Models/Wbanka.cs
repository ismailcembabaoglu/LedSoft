using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wbanka
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkilitel { get; set; }

    public string? Hesapno { get; set; }

    public string? Iban { get; set; }

    public string? Banka { get; set; }

    public string? Sube { get; set; }

    public string? Muhasebekodu { get; set; }

    public string? Dovizcinsi { get; set; }

    public bool? Aktif { get; set; }

    public int Subeid { get; set; }
}
