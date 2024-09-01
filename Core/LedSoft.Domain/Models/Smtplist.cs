using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Smtplist
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public string? EmailSmtpServer { get; set; }

    public int? EmailSmtpPort { get; set; }

    public string? EmailUsername { get; set; }

    public string? EmailPassword { get; set; }

    public string? EmailAddress { get; set; }

    public string? EmailName { get; set; }

    public bool? EmailUsessl { get; set; }
}
