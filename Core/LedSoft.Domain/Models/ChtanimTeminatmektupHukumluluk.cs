using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimTeminatmektupHukumluluk
{
    public long Id { get; set; }

    public long? Teminatmektupid { get; set; }

    public string? Hukumluluk { get; set; }
}
