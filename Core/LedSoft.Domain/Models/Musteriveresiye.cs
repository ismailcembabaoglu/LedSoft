using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Musteriveresiye
{
    public long Id { get; set; }

    public long? Musteriid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public long? Fisid { get; set; }

    public string? Tip { get; set; }

    public long? Subeid { get; set; }

    public long? Kasaid { get; set; }

    public long? Personelid { get; set; }

    public long? Oturumid { get; set; }

    public string? Aciklama { get; set; }
}
