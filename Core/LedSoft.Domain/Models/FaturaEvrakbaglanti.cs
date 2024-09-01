using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FaturaEvrakbaglanti
{
    public long Id { get; set; }

    public long? Faturaid { get; set; }

    public long? Irsaliyeid { get; set; }

    public long? Siparisid { get; set; }
}
