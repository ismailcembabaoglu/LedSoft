using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Aracyakit
{
    public long Id { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public long? Aracid { get; set; }

    public decimal? Yakitdeger { get; set; }

    public string? Yakitbirim { get; set; }
}
