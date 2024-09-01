using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class AracEkekipman
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public string? Tip { get; set; }

    public string? Serino { get; set; }

    public string? Aciklama { get; set; }
}
