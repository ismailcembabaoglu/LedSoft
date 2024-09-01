using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimChgrupdetay
{
    public long Id { get; set; }

    public long? Chgrupid { get; set; }

    public long? Chid { get; set; }

    public bool? Aktif { get; set; }

    public long? Sevkadresid { get; set; }

    public int? Sira { get; set; }
}
