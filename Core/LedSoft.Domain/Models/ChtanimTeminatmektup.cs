using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimTeminatmektup
{
    public long Id { get; set; }

    public string? Teminatyonu { get; set; }

    public string? Teminattip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarih { get; set; }

    public long? Chid { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public string? Banka { get; set; }

    public string? Bankasube { get; set; }

    public decimal? Tutar { get; set; }

    public byte[]? Gorsel { get; set; }

    public bool? Aktif { get; set; }
}
