using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PersonelSube
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public long? Subeid { get; set; }

    public bool? Aktif { get; set; }
}
