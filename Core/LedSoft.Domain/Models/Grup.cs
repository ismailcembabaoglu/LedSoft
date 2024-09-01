using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Grup
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tip { get; set; }

    public bool? Aktif { get; set; }

    public string? Ozelkod { get; set; }
}
