using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DepotanimAdre
{
    public long Id { get; set; }

    public long? Depoid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public bool? Aktif { get; set; }

    public string? Barkod { get; set; }
}
