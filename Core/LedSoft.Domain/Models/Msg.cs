using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Msg
{
    public int Id { get; set; }

    public int? Sender { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }
}
