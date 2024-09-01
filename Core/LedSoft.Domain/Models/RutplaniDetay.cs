using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class RutplaniDetay
{
    public long Id { get; set; }

    public long? Chgrupid { get; set; }

    public bool? Aktif { get; set; }

    public long? Rutplanid { get; set; }

    public string? Gun { get; set; }
}
