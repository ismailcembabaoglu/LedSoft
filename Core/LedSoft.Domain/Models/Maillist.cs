using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Maillist
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }
}
