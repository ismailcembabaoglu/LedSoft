using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class TemplatesAuth
{
    public int Id { get; set; }

    public int? Templateid { get; set; }

    public int? Authorityid { get; set; }

    public string? Value { get; set; }
}
