using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DepotanimDepogrupdetay
{
    public long Id { get; set; }

    public long? Depogrupid { get; set; }

    public long? Depoid { get; set; }

    public bool? Aktif { get; set; }
}
