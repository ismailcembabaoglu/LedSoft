using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class HedefDetay
{
    public long Id { get; set; }

    public long? Hedefid { get; set; }

    public long? Temsilciid { get; set; }

    public decimal? Satistutar { get; set; }

    public decimal? Tahsilattutar { get; set; }

    public decimal? Faturavade { get; set; }

    public decimal? Satismiktar { get; set; }
}
