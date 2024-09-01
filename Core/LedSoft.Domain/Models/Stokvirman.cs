using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Stokvirman
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public long? Depoid { get; set; }

    public long? Subeid { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public long? Temsilciid { get; set; }

    public long? Projeid { get; set; }
}
