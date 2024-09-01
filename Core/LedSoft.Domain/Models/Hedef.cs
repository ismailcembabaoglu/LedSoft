using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Hedef
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Baslangictarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public bool? Aktif { get; set; }

    public long? Subeid { get; set; }
}
