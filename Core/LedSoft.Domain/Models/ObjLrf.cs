using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjLrf
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Reportxml { get; set; }

    public bool? Locked { get; set; }

    public bool? Systemlocked { get; set; }

    public bool? Active { get; set; }

    public string? Projectcode { get; set; }

    public DateTime? Createdatetime { get; set; }

    public DateTime? Modifydatetime { get; set; }

    public DateTime? Publishdatetime { get; set; }
}
