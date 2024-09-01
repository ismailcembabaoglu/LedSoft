using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SubetanimKasaPo
{
    public long Id { get; set; }

    public long? Posid { get; set; }

    public bool? Aktif { get; set; }

    public long? Kasaid { get; set; }
}
