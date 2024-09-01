using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FaturaMasrafkalem
{
    public long Id { get; set; }

    public long? Faturaid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Chid { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public string? Tutartip { get; set; }

    public long? Projeid { get; set; }

    public string? Hareketozelkod { get; set; }

    public string? Evrakno { get; set; }
}
