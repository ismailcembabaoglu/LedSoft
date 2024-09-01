using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PosyazarkasaPlulog
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public long? Subeid { get; set; }

    public long? Kasaid { get; set; }

    public long? Stokid { get; set; }

    public string? Barkod { get; set; }

    public string? Checkdata { get; set; }
}
