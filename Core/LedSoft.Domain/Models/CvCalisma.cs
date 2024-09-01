using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class CvCalisma
{
    public long Id { get; set; }

    public long? Cvid { get; set; }

    public string? Firma { get; set; }

    public string? Departman { get; set; }

    public string? Gorev { get; set; }

    public string? Calismasure { get; set; }
}
