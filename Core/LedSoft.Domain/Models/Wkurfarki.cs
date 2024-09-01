using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wkurfarki
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public long? Chid { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public int Sira { get; set; }

    public long? Temsilciid { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public string? Dovizcinsi { get; set; }

    public string? Dovizcinsi2 { get; set; }

    public long Subeid { get; set; }

    public long? Projeid { get; set; }

    public string? Hareketozelkod { get; set; }
}
