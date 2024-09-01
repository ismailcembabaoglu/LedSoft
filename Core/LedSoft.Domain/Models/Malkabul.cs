using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Malkabul
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Chid { get; set; }

    public long? Depoid { get; set; }

    public string? Evrakno { get; set; }

    public string? Aciklama { get; set; }

    public long? Subeid { get; set; }

    public long? Evrakid { get; set; }

    public int? Temsilciid { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public Guid? Udid { get; set; }
}
