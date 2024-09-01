using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Izlemelink
{
    public long Id { get; set; }

    public long? Kullaniciid { get; set; }

    public long? Aracid { get; set; }

    public DateTime? Gonderimzaman { get; set; }

    public DateTime? Songecerlilikzaman { get; set; }

    public Guid? Udid { get; set; }

    public bool? Iptal { get; set; }
}
