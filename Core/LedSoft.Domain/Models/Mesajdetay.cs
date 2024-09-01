using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Mesajdetay
{
    public long Id { get; set; }

    public long? Mesajid { get; set; }

    public long? Aliciid { get; set; }

    public long? Kasaid { get; set; }

    public bool? Okundu { get; set; }
}
