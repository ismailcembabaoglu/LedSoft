using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class CarihareketKktaksit
{
    public long Id { get; set; }

    public long? Carihareketid { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? Tutar { get; set; }
}
