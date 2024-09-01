using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Aracbilinmeyenkonum
{
    public long Id { get; set; }

    public string? Imei { get; set; }

    public long? Enlem { get; set; }

    public long? Boylam { get; set; }
}
