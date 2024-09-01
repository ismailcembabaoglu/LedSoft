using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wsati
{
    public long Id { get; set; }

    public long? Satisid { get; set; }

    public long? Musteriid { get; set; }

    public long? Personelid { get; set; }

    public long? Subeid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Oturumid { get; set; }

    public long? Kasaid { get; set; }

    public long Ledrefid { get; set; }

    public long? Stokid { get; set; }

    public long? Varyasyonid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Maltoplam { get; set; }

    public decimal Iskonto { get; set; }

    public decimal? Tutar { get; set; }
}
