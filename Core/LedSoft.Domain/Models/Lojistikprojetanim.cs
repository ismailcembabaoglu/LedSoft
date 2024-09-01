using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Lojistikprojetanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public long? Chid { get; set; }

    public bool? Aktif { get; set; }

    public bool? Stokhareketetki { get; set; }

    public bool? Tumstok { get; set; }

    public string? Entegrasyonkod { get; set; }

    public string? SiparisnosorFatura { get; set; }

    public string? SiparisnosorIrsaliye { get; set; }
}
