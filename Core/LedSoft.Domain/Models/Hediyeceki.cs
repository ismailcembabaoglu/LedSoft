using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Hediyeceki
{
    public long Id { get; set; }

    public string? Hediyecekno { get; set; }

    public decimal? Tutar { get; set; }

    public long? Fisid { get; set; }
}
