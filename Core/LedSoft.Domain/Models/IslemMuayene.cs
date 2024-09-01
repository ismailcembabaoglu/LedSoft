using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemMuayene
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? SonrakiTarih { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public long? Carihareketid { get; set; }
}
