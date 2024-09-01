using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Palet
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public bool? Yazdirildi { get; set; }

    public long? Yaziciid { get; set; }

    public long? Chid { get; set; }

    public long? Depoid { get; set; }

    public DateTime? Skt { get; set; }

    public bool? Iptal { get; set; }

    public long? Depoadresid { get; set; }

    public Guid? Udid { get; set; }

    public DateTime? IptalTarihsaat { get; set; }
}
