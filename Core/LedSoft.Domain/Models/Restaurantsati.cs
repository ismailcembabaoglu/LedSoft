using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Restaurantsati
{
    public long Id { get; set; }

    public long? Masaid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Siparisno { get; set; }

    public bool? Yazdirildi { get; set; }

    public Guid? Udid { get; set; }

    public bool? Odendi { get; set; }

    public decimal? Odenenmiktar { get; set; }
}
