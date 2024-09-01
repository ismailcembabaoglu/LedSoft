using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Arackonum
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public string? Tip { get; set; }

    public long? Enlem { get; set; }

    public long? Boylam { get; set; }

    public int? Hiz { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public int? Yon { get; set; }

    public int? Uydusayisi { get; set; }

    public int? Mesafe { get; set; }

    public int? Yukseklik { get; set; }

    public bool? Kontak { get; set; }

    public int? Sicaklik { get; set; }

    public bool? Batarya { get; set; }
}
