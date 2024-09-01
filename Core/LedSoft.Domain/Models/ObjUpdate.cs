using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjUpdate
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Developeruser { get; set; }

    public string? Brief { get; set; }

    public string? Declaration { get; set; }

    public byte[]? Image { get; set; }

    public DateTime? DevDate { get; set; }

    public DateTime? DevTime { get; set; }

    public string? Projectcode { get; set; }

    public string? Updategroup { get; set; }
}
