using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ZraporDepartmantanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public decimal? Kdvoran { get; set; }

    public bool? Aktif { get; set; }

    public decimal? Fiyat { get; set; }

    public long? Birimid { get; set; }

    public string? Entegrasyonkod { get; set; }
}
