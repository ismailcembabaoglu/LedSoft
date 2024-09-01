using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimChnot
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }
}
