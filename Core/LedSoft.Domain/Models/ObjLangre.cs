using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjLangre
{
    public int Id { get; set; }

    public string? Langcode { get; set; }

    public string? Code { get; set; }

    public string? Text { get; set; }

    public string? Projectcode { get; set; }

    public string? Def { get; set; }
}
