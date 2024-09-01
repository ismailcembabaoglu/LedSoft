using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimGrupdetay
{
    public long Id { get; set; }

    public long? Stokgrupid { get; set; }

    public long? Stokid { get; set; }

    public bool? Aktif { get; set; }
}
