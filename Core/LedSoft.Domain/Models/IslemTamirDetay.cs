using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemTamirDetay
{
    public long Id { get; set; }

    public long? Tamirid { get; set; }

    public string? Yapilan { get; set; }

    public decimal? Tutar { get; set; }
}
