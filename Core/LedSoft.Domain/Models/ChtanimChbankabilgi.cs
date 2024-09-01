using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimChbankabilgi
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Isim { get; set; }

    public string? Subekod { get; set; }

    public string? Subeisim { get; set; }

    public string? Hesapno { get; set; }

    public string? Ibanno { get; set; }
}
