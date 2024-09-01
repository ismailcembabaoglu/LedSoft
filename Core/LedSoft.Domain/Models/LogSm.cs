using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogSm
{
    public long Id { get; set; }

    public long? Userid { get; set; }

    public string? Receiver { get; set; }

    public int? Counter { get; set; }

    public int? Counterused { get; set; }

    public string? Message { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Source { get; set; }

    public string? Sourceobj { get; set; }

    public string? Caption { get; set; }
}
