using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Personelistek
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public long? Subeid { get; set; }

    public long? Oturumid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Ozet { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonucaciklama { get; set; }

    public bool? Kapali { get; set; }

    public long? Kasaid { get; set; }
}
