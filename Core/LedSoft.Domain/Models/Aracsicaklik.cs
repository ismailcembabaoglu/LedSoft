﻿using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Aracsicaklik
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public int? Sicaklik { get; set; }

    public int? Bolgeno { get; set; }
}
