using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimPsAnlasma
{
    public long Id { get; set; }

    public long? Posid { get; set; }

    public decimal? Kesinti { get; set; }

    public bool? Aktif { get; set; }

    public string? Aciklama { get; set; }

    public int? Vadegun { get; set; }
}
