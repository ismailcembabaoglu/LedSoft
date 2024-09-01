using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogAuth
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Detail { get; set; }

    public long? Sessionid { get; set; }

    public long? Modifieduserid { get; set; }

    public string? Authcode { get; set; }

    public string? Oldvalue { get; set; }

    public string? Newvalue { get; set; }
}
