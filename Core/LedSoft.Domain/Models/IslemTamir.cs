using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemTamir
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public string? Tip { get; set; }

    public string? Sebep { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Servistegecensure { get; set; }

    public string? Evrakno { get; set; }

    public long? Chid { get; set; }

    public string? Carikart { get; set; }

    public long? Carihareketid { get; set; }

    public string? Carihareketoptip { get; set; }

    public bool? Muhasebe { get; set; }

    public string? Chidisim { get; set; }
}
