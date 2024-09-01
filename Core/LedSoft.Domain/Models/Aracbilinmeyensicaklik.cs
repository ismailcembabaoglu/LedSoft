using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Aracbilinmeyensicaklik
{
    public long Id { get; set; }

    public string? Imei { get; set; }

    public decimal? Sicaklik { get; set; }
}
