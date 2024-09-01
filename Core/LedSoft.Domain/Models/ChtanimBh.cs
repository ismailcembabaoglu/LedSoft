using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimBh
{
    public long Id { get; set; }

    public string? Banka { get; set; }

    public string? Sube { get; set; }

    public string? Iban { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkilitel { get; set; }

    public string? Muhasebekodu { get; set; }

    public long? Chid { get; set; }

    public string? Hesapno { get; set; }

    public long? LedmuhHesapid { get; set; }

    public string? Entegrasyonkod { get; set; }
}
