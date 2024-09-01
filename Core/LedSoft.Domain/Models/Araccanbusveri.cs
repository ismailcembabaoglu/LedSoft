using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Araccanbusveri
{
    public long Id { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public long? Aracid { get; set; }

    public int? Es { get; set; }

    public int? Ect { get; set; }

    public int? Ws { get; set; }

    public int? Fl { get; set; }

    public int? Hrvd { get; set; }
}
