using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SubetanimSabitmasraf
{
    public long Id { get; set; }

    public long? Subeid { get; set; }

    public DateTime? Baslangictarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public decimal? Aylik { get; set; }

    public string? Aciklama { get; set; }

    public long? Sabitgiderid { get; set; }
}
