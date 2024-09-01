using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Arackmozet
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public long? Aracid { get; set; }

    public int? Km { get; set; }

    public int? Mesafe { get; set; }
}
