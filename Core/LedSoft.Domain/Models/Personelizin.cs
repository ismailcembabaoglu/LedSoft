using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Personelizin
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public long? Izinid { get; set; }

    public DateTime? Baslangictarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public string? Aciklama { get; set; }
}
