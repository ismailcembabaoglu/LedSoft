using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Kullanicimobilbildirim
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public long? Kullaniciid { get; set; }

    public string? Ayar { get; set; }

    public string? Kullaniciudid { get; set; }

    public long? Checksum { get; set; }
}
