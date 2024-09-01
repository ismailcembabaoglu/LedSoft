using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SurucuEhliyet
{
    public long Id { get; set; }

    public long? Surucuid { get; set; }

    public DateTime? VerilisTarihi { get; set; }

    public DateTime? GecerlilikTarihi { get; set; }

    public string? EhliyetSinif { get; set; }
}
