using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjFile
{
    public long Id { get; set; }

    public long? Plgobjectid { get; set; }

    public byte[]? Fl { get; set; }

    public string? FlHash { get; set; }

    public string? FlName { get; set; }

    public string? FlPath { get; set; }

    public bool? Active { get; set; }

    public string? Projectcode { get; set; }

    public DateTime? Modifydatetime { get; set; }
}
