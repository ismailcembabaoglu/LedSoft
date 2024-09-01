using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wyakitfi
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Aracid { get; set; }

    public long? Surucuid { get; set; }

    public bool? Tamdolum { get; set; }

    public decimal? Km { get; set; }

    public decimal? Yakitlitre { get; set; }

    public decimal? Tutar { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Zaman { get; set; }

    public DateTime? Oncekitamdolumzaman { get; set; }
}
