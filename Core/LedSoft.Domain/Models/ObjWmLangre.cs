using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjWmLangre
{
    public long Id { get; set; }

    public string? Langcode { get; set; }

    public string? Keystr { get; set; }

    public string? Valuestr { get; set; }

    public string? Projectcode { get; set; }
}
