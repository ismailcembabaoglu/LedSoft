using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimLisan
{
    public long Id { get; set; }

    public string? Dil { get; set; }

    public long? Stokid { get; set; }

    public string? Isim { get; set; }
}
