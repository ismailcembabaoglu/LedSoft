using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Sayim
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public long? Depoid { get; set; }

    public string? Aciklama { get; set; }

    public string? Evrakno { get; set; }

    public bool? Tip { get; set; }

    public long? Depogirisid { get; set; }

    public long? Depocikisid { get; set; }

    public bool? Aktarildi { get; set; }

    public int? Temsilciid { get; set; }

    public int? Subeid { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public int? Coklusayim { get; set; }

    public Guid? Udid { get; set; }

    public DateTime? Uyarlamatarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur { get; set; }

    public string? Sayimtip { get; set; }

    public long? Chid { get; set; }

    public long? Sevkadresid { get; set; }
}
