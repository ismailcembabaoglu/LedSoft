using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class La
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Conditionsql { get; set; }

    public string? Servicetype { get; set; }

    public string? Datasql { get; set; }

    public string? Resultsql { get; set; }

    public string? Frxfilename { get; set; }

    public byte[]? Frxfile { get; set; }

    public string? Frxfilehash { get; set; }

    public string? Attachmentfilename { get; set; }

    public string? Projectcode { get; set; }

    public bool? Active { get; set; }

    public string? Timerule { get; set; }
}
