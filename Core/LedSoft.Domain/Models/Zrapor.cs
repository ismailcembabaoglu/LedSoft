using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Zrapor
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Zfisno { get; set; }

    public long? Subeid { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Nakittutar { get; set; }

    public decimal? Postutar { get; set; }

    public decimal? Faturatutar { get; set; }

    public decimal? Yemekcekitutar { get; set; }
}
