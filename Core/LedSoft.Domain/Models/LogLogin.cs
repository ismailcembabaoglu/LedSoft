using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogLogin
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public DateTime? LoginDatetime { get; set; }

    public DateTime? LogoutDatetime { get; set; }

    public string? Clientip { get; set; }

    public string? Clientwanip { get; set; }

    public string? Clientmac { get; set; }
}
