using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Fiyatanlasma
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public long? Tedarikciid { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Baslangictarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public bool? Aktif { get; set; }
}
