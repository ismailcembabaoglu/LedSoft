using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PersonelKesinti
{
    public long Id { get; set; }

    public long? Personelid { get; set; }

    public long? Giderid { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Tutar { get; set; }
}
