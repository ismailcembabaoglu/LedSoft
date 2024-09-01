using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Mobilkullanici
{
    public long Id { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Parola { get; set; }

    public string? Grup { get; set; }

    public bool? Aktif { get; set; }

    public string? Isim { get; set; }

    public string? Aciklama { get; set; }

    public string? Gsm { get; set; }

    public string? Eposta { get; set; }

    public string? Kullanicigrupkod { get; set; }

    public string? Aracgrupkod { get; set; }

    public Guid? OnesignalUser { get; set; }
}
