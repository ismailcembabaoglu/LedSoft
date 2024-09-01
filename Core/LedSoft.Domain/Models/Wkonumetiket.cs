using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wkonumetiket
{
    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }
}
