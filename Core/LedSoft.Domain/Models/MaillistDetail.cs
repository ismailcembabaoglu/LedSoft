using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class MaillistDetail
{
    public int Id { get; set; }

    public int? Maillistid { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public bool? Active { get; set; }
}
