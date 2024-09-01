using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemCeza
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Aciklama { get; set; }

    public string? Tip { get; set; }

    public DateTime? TebligTarihi { get; set; }

    public DateTime? IndirimTarihi { get; set; }

    public decimal? TutarIndirim { get; set; }

    public DateTime? SonodemeTarihi { get; set; }

    public string? Odeme { get; set; }

    public long? Surucu { get; set; }

    public long? Carihareketid { get; set; }
}
