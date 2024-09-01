using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wkdvmuafiyet
{
    public string Kod { get; set; } = null!;

    public string? Aciklama { get; set; }

    public string Tip { get; set; } = null!;
}
