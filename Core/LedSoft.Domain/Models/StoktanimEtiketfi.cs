using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class StoktanimEtiketfi
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Aciklama { get; set; }

    public bool? Gorselkullan { get; set; }

    public bool? Sabitetiketadetkullan { get; set; }

    public int? Sabitetiketadet { get; set; }

    public bool? Fiyatlistekullan { get; set; }

    public long? Fiyatlisteid { get; set; }

    public bool? Yazdirildi { get; set; }

    public long? Fiyat2listeid { get; set; }
}
