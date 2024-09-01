using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Kampanya
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Aciklama { get; set; }

    public string? Tip { get; set; }

    public decimal? Toplammiktar { get; set; }

    public bool? Aktif { get; set; }

    public bool? Ilktarihvar { get; set; }

    public DateTime? Ilktarih { get; set; }

    public bool? Sontarihvar { get; set; }

    public DateTime? Sontarih { get; set; }

    public int? Carisecimtip { get; set; }
}
