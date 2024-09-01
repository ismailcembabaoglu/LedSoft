using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class WsToken1
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public DateTime? Datetime { get; set; }

    public Guid? Token { get; set; }

    public string? App { get; set; }
}
