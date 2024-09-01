using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LojistikprojetanimTemsilci
{
    public long Id { get; set; }

    public long? Lojistikprojeid { get; set; }

    public long? Temsilciid { get; set; }

    public string? Serino { get; set; }
}
