using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class PrintlayoutsUser
{
    public long Id { get; set; }

    public long? Printlayoutid { get; set; }

    public long? Userid { get; set; }
}
