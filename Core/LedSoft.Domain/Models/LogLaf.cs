using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class LogLaf
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public int? Objectid { get; set; }

    public int? Recordid { get; set; }

    public short? Operationid { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Detail { get; set; }

    public long? Sessionid { get; set; }

    public string? Objectcode { get; set; }

    public bool? Smsgonderildi { get; set; }
}
