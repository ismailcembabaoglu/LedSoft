using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LojistikprojetanimCari
{
    public long Id { get; set; }

    public long? Lojistikprojeid { get; set; }

    public long? Chid { get; set; }

    public bool? Aktif { get; set; }
}
