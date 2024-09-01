using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ServiceLog
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Terminalid { get; set; }

    public string? Xmldata { get; set; }

    public string? Tip { get; set; }

    public long? Mobileuserid { get; set; }

    public string? Version { get; set; }
}
