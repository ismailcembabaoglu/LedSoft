using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Aracguncelbilgi
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public long? Enlem { get; set; }

    public long? Boylam { get; set; }

    public int? Hiz { get; set; }

    public int? Yon { get; set; }

    public bool? Kontak { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public int? Mesafe { get; set; }

    public bool? Batarya { get; set; }

    public DateTime? Sicakliktarihsaat { get; set; }

    public int? Sicaklik { get; set; }

    public string? Konumtip { get; set; }

    public int? Yukseklik { get; set; }

    public int? Bat { get; set; }

    public DateTime? Battarihsaat { get; set; }

    public bool? Batsarj { get; set; }

    public DateTime? Kmtarihsaat { get; set; }

    public long? Km { get; set; }

    public DateTime? Yakittarihsaat { get; set; }

    public decimal? Yakitdeger { get; set; }

    public string? Yakitbirim { get; set; }
}
