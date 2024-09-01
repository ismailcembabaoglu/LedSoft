using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Temsilci
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Telefon { get; set; }

    public string? Eposta { get; set; }

    public string? Bolge { get; set; }

    public string? Telefonkisa { get; set; }

    public string? Ozelkod { get; set; }
}
