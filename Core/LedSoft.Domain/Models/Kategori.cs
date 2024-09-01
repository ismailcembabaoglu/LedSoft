using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Kategori
{
    public long Id { get; set; }

    public string? Tip { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }
}
