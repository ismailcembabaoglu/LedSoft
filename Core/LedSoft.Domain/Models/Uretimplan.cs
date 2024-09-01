using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Uretimplan
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Uretimtarih { get; set; }

    public string? Evrakno { get; set; }

    public string? Aciklama { get; set; }

    public string? Durum { get; set; }
}
