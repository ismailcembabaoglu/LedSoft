using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Stokuretimetiketdetay
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public decimal? Miktar { get; set; }

    public string? Istasyonkod { get; set; }

    public DateTime? Skt { get; set; }

    public long? Stokid { get; set; }

    public long? Ciktiid { get; set; }

    public string? Partino { get; set; }

    public string? Serino { get; set; }

    public string? Personelkod { get; set; }
}
