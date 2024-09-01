using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimBankakrediodemeplan
{
    public long Id { get; set; }

    public long? Bankakrediid { get; set; }

    public int? Taksitno { get; set; }

    public DateTime? Vadetarih { get; set; }

    public decimal? Taksittutar { get; set; }

    public decimal? Kkdf { get; set; }

    public decimal? Bsmv { get; set; }

    public decimal? Bakiye { get; set; }

    public decimal? Faiztutar { get; set; }

    public decimal? Anapara { get; set; }
}
