using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Cv
{
    public long Id { get; set; }

    public string? Tckimlikno { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Evtel { get; set; }

    public string? Ceptel { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Dusunceler { get; set; }

    public string? Notlar { get; set; }

    public byte[]? Resim { get; set; }

    public byte[]? Cv1 { get; set; }

    public string? Adres { get; set; }
}
