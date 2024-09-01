using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wportfoy
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tip { get; set; }

    public long? Bankaid { get; set; }

    public string? Muhasebekodu { get; set; }

    public string? Aciklama { get; set; }

    public int Subeid { get; set; }
}
