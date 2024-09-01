using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ZraporDetay
{
    public long Id { get; set; }

    public long? Zraporid { get; set; }

    public long? Departmanid { get; set; }

    public decimal? Tutar { get; set; }
}
