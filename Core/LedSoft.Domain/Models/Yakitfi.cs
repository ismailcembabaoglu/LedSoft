using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Yakitfi
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

    public byte[]? Gorsel1 { get; set; }

    public byte[]? Gorsel2 { get; set; }

    public long? Chid { get; set; }

    public string? Cari { get; set; }

    public bool? Muhasebe { get; set; }

    public long? Carihareketid { get; set; }

    public string? Carihareketoptip { get; set; }

    public string? Aciklama { get; set; }
}
