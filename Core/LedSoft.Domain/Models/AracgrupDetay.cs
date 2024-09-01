using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class AracgrupDetay
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public bool? Aktif { get; set; }

    public long? Grupid { get; set; }
}
