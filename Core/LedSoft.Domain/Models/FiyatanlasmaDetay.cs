using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FiyatanlasmaDetay
{
    public long Id { get; set; }

    public long? Fiyatanlasmaid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public decimal? Iskonto3 { get; set; }

    public decimal? Iskonto4 { get; set; }

    public decimal? Iskonto5 { get; set; }
}
