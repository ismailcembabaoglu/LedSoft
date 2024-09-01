using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PosyazarkasaTransferlog
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Subeid { get; set; }

    public long? Kasaid { get; set; }

    public string? Islem { get; set; }

    public int? Deger { get; set; }

    public DateTime? Kasamesajtarih { get; set; }

    public string? Kasamesaj { get; set; }

    public long? Kasamesajid { get; set; }

    public long? Kasacevapid { get; set; }

    public int? Kasamesajdurum { get; set; }
}
