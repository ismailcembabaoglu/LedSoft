using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjWmFilebin
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public byte[]? Binary { get; set; }

    public string? Hash { get; set; }

    public DateTime? Modifydatetime { get; set; }

    public string? Projectcode { get; set; }
}
