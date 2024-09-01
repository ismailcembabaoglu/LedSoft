using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FiyatlisteCarigrup
{
    public long Id { get; set; }

    public long? Fiyatlisteid { get; set; }

    public long? Grupid { get; set; }
}
