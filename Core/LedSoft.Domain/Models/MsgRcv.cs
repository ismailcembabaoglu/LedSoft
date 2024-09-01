using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class MsgRcv
{
    public int Id { get; set; }

    public string? Messageid { get; set; }

    public int? Userid { get; set; }

    public DateTime? Seendatetime { get; set; }
}
