using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Mobilbildirimlog
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public string? Kullanicilar { get; set; }
}
