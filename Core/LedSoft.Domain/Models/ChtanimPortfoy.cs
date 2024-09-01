using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimPortfoy
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public long? Bankaid { get; set; }

    public string? Muhasebekodu { get; set; }

    public string? Aciklama { get; set; }

    public long? LedmuhHesapid { get; set; }
}
