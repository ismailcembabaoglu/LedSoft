using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimKoddonusumCari
{
    public long Id { get; set; }

    public long? Urunanlasmaid { get; set; }

    public long? Chid { get; set; }

    public bool? Aktif { get; set; }
}
