using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FiyatlisteAltsevkadre
{
    public long Id { get; set; }

    public long? Fiyataltlisteid { get; set; }

    public long? Sevkadresid { get; set; }
}
