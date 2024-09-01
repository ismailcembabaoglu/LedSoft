using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wfiyatham
{
    public long Fiyatlisteid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tip { get; set; }

    public bool? Aktif { get; set; }

    public string? Islemtip { get; set; }

    public int? Carisecimtip { get; set; }

    public int Sevkadressecimtip { get; set; }

    public long Fiyataltlisteid { get; set; }

    public DateTime? Ilktarih { get; set; }

    public DateTime? Sontarih { get; set; }

    public string? Aciklama { get; set; }

    public bool Kdvdahil { get; set; }
}
