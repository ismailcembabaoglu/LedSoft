using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Ziyaret
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public long? Temsilciid { get; set; }

    public DateTime? Baslangictarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public bool? Gpsonay { get; set; }

    public string? Ziyaretnot { get; set; }

    public long? Faturaid { get; set; }

    public long? Siparisid { get; set; }

    public long? Tahsilatid { get; set; }

    public string? Islemtip { get; set; }

    public long? Sevkadresid { get; set; }

    public DateTime? Baslangicsaat { get; set; }

    public DateTime? Bitissaat { get; set; }

    public long? Bsid { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }
}
