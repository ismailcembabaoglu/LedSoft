using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjWmKeyauth
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Clu1code { get; set; }

    public string? Clu1caption { get; set; }

    public string? Clu2code { get; set; }

    public string? Clu2caption { get; set; }

    public string? Clu3code { get; set; }

    public string? Clu3caption { get; set; }

    public bool? Active { get; set; }

    public string? Projectcode { get; set; }

    public string? Clu1infosqlcode { get; set; }

    public string? Clu2infosqlcode { get; set; }

    public string? Clu3infosqlcode { get; set; }

    public string? Authcode { get; set; }
}
