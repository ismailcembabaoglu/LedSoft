using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Oturum
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public long? Subeid { get; set; }

    public DateTime? Baslangictarih { get; set; }

    public DateTime? Baslangicsaat { get; set; }

    public DateTime? Bitistarih { get; set; }

    public DateTime? Bitissaat { get; set; }

    public bool? Kapali { get; set; }

    public string? Oturumkod { get; set; }

    public long? Kasaid { get; set; }
}
