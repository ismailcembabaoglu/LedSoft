using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemBakim
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public decimal? IlkKm { get; set; }

    public decimal? SonrakiKm { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? Tutar { get; set; }

    public string? Tip { get; set; }

    public string? Carikart { get; set; }

    public string? Evrakno { get; set; }

    public long? Chid { get; set; }

    public string? Aciklama { get; set; }

    public bool? Gosterme { get; set; }

    public string? Chidisim { get; set; }

    public string? Carihareketoptip { get; set; }

    public long? Carihareketid { get; set; }
}
