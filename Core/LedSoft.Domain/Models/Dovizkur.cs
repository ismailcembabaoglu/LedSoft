using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Dovizkur
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur1 { get; set; }
}
