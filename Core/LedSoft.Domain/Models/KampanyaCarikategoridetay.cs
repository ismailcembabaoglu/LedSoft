using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class KampanyaCarikategoridetay
{
    public long Id { get; set; }

    public long? Kampanyaid { get; set; }

    public string? Kategoritip { get; set; }

    public long? Kategoriid { get; set; }
}
