using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimKoddonusum
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public int? Subeid { get; set; }

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }
}
