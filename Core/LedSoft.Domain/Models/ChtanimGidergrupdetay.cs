using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimGidergrupdetay
{
    public long Id { get; set; }

    public long? Gidergrupid { get; set; }

    public bool? Aktif { get; set; }

    public long? Chid { get; set; }
}
