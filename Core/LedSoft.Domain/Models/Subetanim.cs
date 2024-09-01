using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Subetanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Aciklama { get; set; }

    public string? Entegrasyonkod { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Adres { get; set; }
}
