using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FiyatyonetimSablondetay
{
    public long Id { get; set; }

    public long? Sablonid { get; set; }

    public long? Fiyatlisteid { get; set; }

    public long? Fiyataltlisteid { get; set; }
}
