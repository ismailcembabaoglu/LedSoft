using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Gecicistokhareket
{
    public long Id { get; set; }

    public DateTime? Tarihsaat { get; set; }

    public string? Barkod { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Miktar { get; set; }

    public long? Ambalajbirimid { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public long? Mobileuserid { get; set; }

    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public long? Fisid { get; set; }
}
