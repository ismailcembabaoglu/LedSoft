using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimPosgrupdetay
{
    public long Id { get; set; }

    public long? Posgrupid { get; set; }

    public long? Chid { get; set; }

    public bool? Aktif { get; set; }
}
