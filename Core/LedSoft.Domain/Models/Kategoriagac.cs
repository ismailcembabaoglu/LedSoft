using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Kategoriagac
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public long? Kategoriagacid { get; set; }
}
