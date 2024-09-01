using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Subeizlemenot
{
    public long Id { get; set; }

    public long? Subeid { get; set; }

    public string? Personelisim { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonuc { get; set; }

    public int? Yildiz { get; set; }

    public long? Personelid { get; set; }

    public string? Yoneticiaciklama { get; set; }
}
