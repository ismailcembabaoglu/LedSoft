using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogIndex
{
    public long Id { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public string? Indexname { get; set; }

    public string? Tablename { get; set; }

    public decimal? Ratio { get; set; }

    public decimal? Finalratio { get; set; }

    public string? Operation { get; set; }
}
