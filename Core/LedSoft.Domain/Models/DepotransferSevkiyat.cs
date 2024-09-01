using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DepotransferSevkiyat
{
    public long Id { get; set; }

    public long? Depotransferid { get; set; }

    public string? SevkiyatTckn { get; set; }

    public string? SevkiyatAd { get; set; }

    public string? SevkiyatSoyad { get; set; }

    public string? SevkiyatPlaka { get; set; }

    public long? SevkiyatTasiyicichid { get; set; }

    public string? SevkiyatTasiyicivkn { get; set; }

    public string? SevkiyatTasiyiciunvan { get; set; }
}
