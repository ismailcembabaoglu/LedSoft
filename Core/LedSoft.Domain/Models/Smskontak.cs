using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Smskontak
{
    public long Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Adres { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Mahalle { get; set; }

    public string? Ozelkod1 { get; set; }

    public string? Ozelkod2 { get; set; }

    public string? Dijitaltel { get; set; }

    public string? Ozelkod3 { get; set; }
}
