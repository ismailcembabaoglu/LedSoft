using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wfaturadeger
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? Matrah { get; set; }

    public decimal? Otv { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? Dovizkur { get; set; }

    public decimal? Doviztutar { get; set; }
}
