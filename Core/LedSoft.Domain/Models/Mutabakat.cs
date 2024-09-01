using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Mutabakat
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Aciklama { get; set; }

    public string? Tip { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public DateTime? Bakiyetarih { get; set; }

    public bool? Yazdirildi { get; set; }
}
