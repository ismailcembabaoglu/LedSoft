using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Fiyatteklif
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public DateTime? Gecerlilikbaslangictarih { get; set; }

    public DateTime? Gecerlilikbitistarih { get; set; }

    public string? Evrakno { get; set; }

    public string? Kosul { get; set; }

    public string? Notlar { get; set; }
}
