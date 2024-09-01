using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SubetanimYazarkasa
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Yazarkasatip { get; set; }

    public string? Kontroldizin { get; set; }

    public string? Iletisimdizin { get; set; }

    public bool? Aktif { get; set; }

    public long? Subeid { get; set; }

    public string? Dosyauzanti { get; set; }

    public string? Veridizin { get; set; }

    public int? Yazarkasarefid { get; set; }
}
