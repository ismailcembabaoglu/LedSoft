﻿using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ReceteAmbalajdetay
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Miktar { get; set; }

    public long? Receteid { get; set; }

    public long? Depoid { get; set; }
}
