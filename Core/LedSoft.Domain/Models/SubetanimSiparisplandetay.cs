using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SubetanimSiparisplandetay
{
    public long Id { get; set; }

    public long? Siparisplanid { get; set; }

    public DateTime? Baslangicsaat { get; set; }

    public DateTime? Bitissaat { get; set; }

    public long? Stokkategoriid { get; set; }

    public int? Teslimgun { get; set; }

    public string? Aciklama { get; set; }

    public bool? Siparisizin { get; set; }
}
