using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class CvEgitim
{
    public long Id { get; set; }

    public long? Cvid { get; set; }

    public string? Okul { get; set; }

    public string? Bolum { get; set; }

    public string? Durum { get; set; }
}
