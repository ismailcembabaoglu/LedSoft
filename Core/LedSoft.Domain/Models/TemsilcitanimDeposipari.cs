using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class TemsilcitanimDeposipari
{
    public long Id { get; set; }

    public long? Temsilciid { get; set; }

    public string? DsDeposecimtip { get; set; }

    public long? DsDepoid { get; set; }

    public long? DsDepogrupid { get; set; }

    public string? DsStokgruplamasekli { get; set; }
}
