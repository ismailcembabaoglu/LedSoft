using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimTedarikci
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Aciklama { get; set; }

    public long? Stokid { get; set; }
}
