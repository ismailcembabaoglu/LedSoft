using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemBakimDetay
{
    public long Id { get; set; }

    public long? Bakimid { get; set; }

    public string? Bakim { get; set; }

    public decimal? Fiyat { get; set; }
}
