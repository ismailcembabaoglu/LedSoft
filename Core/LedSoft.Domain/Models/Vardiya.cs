using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Vardiya
{
    public long Id { get; set; }

    public string? Vardiyano { get; set; }

    public DateTime? Baslangicsaat { get; set; }

    public DateTime? Bitissaat { get; set; }
}
