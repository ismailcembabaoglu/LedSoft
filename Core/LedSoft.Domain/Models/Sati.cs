using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Sati
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Personelid { get; set; }

    public long? Subeid { get; set; }

    public long? Kasaid { get; set; }

    public long? Musteriid { get; set; }

    public long? Oturumid { get; set; }

    public decimal? Nakit { get; set; }

    public decimal? Pos { get; set; }

    public long? Ledrefid { get; set; }

    public int? YkFisno { get; set; }

    public int? YkZno { get; set; }

    public int? YkKredino { get; set; }

    public Guid? Udid { get; set; }

    public string? Aciklama { get; set; }

    public int? Fisno { get; set; }

    public long? Posid { get; set; }

    public long? Satisdanismanid { get; set; }
}
