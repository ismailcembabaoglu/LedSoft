using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Temsilcisahahareket
{
    public long Id { get; set; }

    public long? Temsilciid { get; set; }

    public DateTime? Gbsaat { get; set; }

    public long? Gbkm { get; set; }

    public long? Gbgpsenlem { get; set; }

    public long? Gbgpsboylam { get; set; }

    public DateTime? Gssaat { get; set; }

    public long? Gskm { get; set; }

    public long? Gsgpsenlem { get; set; }

    public long? Gsgpsboylam { get; set; }

    public DateTime? Tarih { get; set; }
}
