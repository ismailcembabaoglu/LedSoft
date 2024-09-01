using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogDbexec
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public long? Sessionid { get; set; }

    public DateTime? Execdatetime { get; set; }

    public string? Sqlcode { get; set; }

    public int? Selstart { get; set; }

    public int? Sellength { get; set; }

    public int? Duration { get; set; }

    public bool? Error { get; set; }

    public bool? Stopped { get; set; }

    public int? Tables { get; set; }

    public int? Rows { get; set; }

    public int? Affected { get; set; }
}
