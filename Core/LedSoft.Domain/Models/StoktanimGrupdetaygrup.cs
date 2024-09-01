using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimGrupdetaygrup
{
    public long Id { get; set; }

    public long? Stokgrupid { get; set; }

    public long? Grupid { get; set; }

    public bool? Aktif { get; set; }
}
