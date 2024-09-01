using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Kampanyatanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public DateTime? Ilktarih { get; set; }

    public DateTime? Sontarih { get; set; }

    public string? Tip { get; set; }
}
