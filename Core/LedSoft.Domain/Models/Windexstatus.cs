using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Windexstatus
{
    public int Objectid { get; set; }

    public decimal? Ratio { get; set; }

    public string? Tableschema { get; set; }

    public string Tablename { get; set; } = null!;

    public string? Indexname { get; set; }

    public int Indexid { get; set; }

    public bool? Primarykey { get; set; }
}
