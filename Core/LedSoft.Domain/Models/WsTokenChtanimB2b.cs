﻿using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class WsTokenChtanimB2b
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public DateTime? Datetime { get; set; }

    public Guid? Token { get; set; }
}
