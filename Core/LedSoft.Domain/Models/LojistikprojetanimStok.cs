using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LojistikprojetanimStok
{
    public long Id { get; set; }

    public long? Lojistikprojeid { get; set; }

    public long? Stokid { get; set; }

    public bool? Aktif { get; set; }
}
