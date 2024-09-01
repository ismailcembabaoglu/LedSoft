using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wpersonel
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tckn { get; set; }

    public DateTime? Dogumtarihi { get; set; }

    public string? Dogumyeri { get; set; }

    public string? Anaadi { get; set; }

    public string? Babaadi { get; set; }

    public string Medenihali { get; set; } = null!;

    public string Kangrubu { get; set; } = null!;

    public decimal? Maas { get; set; }

    public decimal? Agi { get; set; }

    public long? Maasgiderid { get; set; }

    public long? Agigiderid { get; set; }

    public int? Departmanid { get; set; }

    public int? Gorevid { get; set; }

    public long? Kategori1id { get; set; }

    public long? Kategori2id { get; set; }

    public long? Kategori3id { get; set; }

    public bool Aktif { get; set; }

    public int Subeid { get; set; }
}
