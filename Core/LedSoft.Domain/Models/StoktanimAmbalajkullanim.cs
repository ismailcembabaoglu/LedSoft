using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimAmbalajkullanim
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public long? Ambalajbirimid { get; set; }

    public bool? Esikdegerkullan { get; set; }

    public decimal? Esikbuyukdeger { get; set; }

    public decimal? Esikkucukdeger { get; set; }
}
