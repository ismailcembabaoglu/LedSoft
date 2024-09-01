using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wmusteri
{
    public long Id { get; set; }

    public string? Kartid { get; set; }

    public string? Isim { get; set; }

    public string? Adres { get; set; }

    public string? Pin { get; set; }

    public string? Gsm { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public bool? Vrs { get; set; }

    public decimal? Vrsul { get; set; }

    public decimal? Vrskl { get; set; }

    public int? Vrsvd { get; set; }

    public string? Msg { get; set; }

    public bool Aktif { get; set; }

    public long? Sid { get; set; }

    public string? Iskontotip { get; set; }

    public decimal? Iskonto { get; set; }

    public string Acikhesap { get; set; } = null!;
}
