using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wkasa
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Aciklama { get; set; }

    public string? Muhasebekodu { get; set; }

    public string? Dovizcinsi { get; set; }

    public bool? Aktif { get; set; }

    public int Subeid { get; set; }
}
