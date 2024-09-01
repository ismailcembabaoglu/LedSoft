using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FaturaSevkiyat
{
    public long Id { get; set; }

    public long? Faturaid { get; set; }

    public string? SevkiyatTckn { get; set; }

    public string? SevkiyatAd { get; set; }

    public string? SevkiyatSoyad { get; set; }

    public string? SevkiyatPlaka { get; set; }

    public string? TasiyiciVkn { get; set; }

    public string? TasiyiciUnvan { get; set; }

    public string? SevkiyatGsm { get; set; }
}
