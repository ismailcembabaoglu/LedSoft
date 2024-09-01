using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Hatirlatma
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public DateTime? Hatirlatmatarih { get; set; }

    public long? Kullaniciid { get; set; }

    public string? Renk { get; set; }

    public string? Kullanicitip { get; set; }

    public DateTime? Hatirlatmatarih2 { get; set; }

    public string? Hatirlatmatarihtip { get; set; }
}
