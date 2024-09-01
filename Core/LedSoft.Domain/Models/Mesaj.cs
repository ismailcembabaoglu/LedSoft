using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Mesaj
{
    public long Id { get; set; }

    public long? Gondericiid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Mesaj1 { get; set; }
}
