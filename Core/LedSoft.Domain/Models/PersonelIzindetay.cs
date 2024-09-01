using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PersonelIzindetay
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public long? Izinid { get; set; }

    public long? Izingunsayisi { get; set; }
}
