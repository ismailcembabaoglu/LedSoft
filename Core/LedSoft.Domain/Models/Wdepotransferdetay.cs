using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wdepotransferdetay
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Aciklama { get; set; }

    public string? Tip { get; set; }

    public long? Kaynakdepoid { get; set; }

    public long? Hedefdepoid { get; set; }

    public decimal? Tutar { get; set; }

    public int Subeid { get; set; }
}
